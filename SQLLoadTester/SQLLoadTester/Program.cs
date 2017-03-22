using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SQLLoadTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultUsersNumber = 10;

            if (args.Length != 0)
            {
                Console.WriteLine("No params specified, using defaults...");
                defaultUsersNumber = int.Parse(args[0]);
            }

            for (var i = 0; i < defaultUsersNumber; i++)
            {
                //run command in endless loop with intervals of 1 sec
                RunCmd("\"select * from Person.Person\"", 1000, true, 10);
            }
        }

        private static async void RunCmd(string cmd, int runEveryMs, bool isLoop, int stopAfter)
        {
            var command = $"\"CmdRunner.exe {cmd} {runEveryMs} {isLoop} {stopAfter}\"";

            await Task.Run(() =>
            {
                RunCmdSync(command);
            });
        }

        private static void RunCmdAsync(string cmd, int runEveryMs, bool isLoop, int stopAfter)
        {
            var command = $"CmdRunner.exe {cmd} {runEveryMs} {isLoop} {stopAfter}";

            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(RunCmdSync));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException)
            {
                // Log the exception
            }
            catch (ThreadAbortException)
            {
                // Log the exception
            }
            catch (Exception)
            {
                // Log the exception
            }
        }

        private static void RunCmdSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                var procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                // Do not create the black window.
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                // Log the exception
            }
        }
    }
}
