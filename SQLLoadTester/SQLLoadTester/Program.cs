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
            int defaultUsersNumber = 10;
            int defaultThreadsPerUser = 10;

           var defaultCommand = "EXEC [dbo].[vp_syUpdateSessionStatus] @strHstryUserName = N\'SysAdmin\'" +
                          ",@strHstryTaskName = N\'Scheduling\',@nDebug = 3," +
                          "@strCompletePlanUID01 = N\'1.2.246.352.71.5.339051055.1345.20080812155642\'";

            if (args.Length > 0)
            {
                Console.WriteLine("No params specified, using defaults...");
                defaultUsersNumber = int.Parse(args[0]);
            }

            //run
            new ThreadRunners.SqlCommands().RunSqlCmdThread(defaultCommand, defaultUsersNumber, defaultThreadsPerUser);
        }
    }
}
