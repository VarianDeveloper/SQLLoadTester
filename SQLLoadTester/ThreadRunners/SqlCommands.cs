using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadRunners
{
    public class SqlCommands
    {
        public void RunSqlCmdThread(string cmd = null, int users = 1, int threads = 1)
        {
            var command = cmd ?? @"select * from pt";
            var numberOfThreads = threads;
            var numberOfUsers = users;

            var usersHash = CreateUsersHash(numberOfUsers, numberOfThreads);
            Console.WriteLine($"Total User Hash : {usersHash.Count}");
            try
            {
                string nextUser = GetRandomUserThread(usersHash, false);
                var threadsList = new List<Thread>();

                while (!string.IsNullOrEmpty(nextUser))
                {
                    var user = int.Parse(nextUser.Split(',')[0]);
                    var userThread = int.Parse(nextUser.Split(',')[1]);

                    threadsList.Add(
                            new Thread(p =>
                            {
                                CreateThread(command, user, userThread);
                            }));

                    //update current user as ran
                    usersHash[nextUser] = true;

                    //get next random user that wasn't ran yet
                    nextUser = GetRandomUserThread(usersHash, false);
                }

                //start all threads
                foreach (var thread in threadsList)
                {
                    thread.Start();
                }

                Console.WriteLine($"Total started: {threadsList.Count}");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void CreateThread(string command, int userId, int threadId)
        {
            var myConnection = new SqlConnection("user id=sa;" +
                                      "password=Sa_sqlboxpwd12345;server=10.4.194.152;" +
                                      //"Trusted_Connection=yes;" +
                                      "database=VARIAN; " +
                                      $"connection timeout={int.MaxValue}");
            var myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();

            Console.WriteLine($"Starting User {userId}, Thread No {threadId} at {DateTime.Now}");

            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }

        private static Dictionary<string, bool> CreateUsersHash(int numberOfUsers, int numberOfThreads)
        {
            var usersHash = new Dictionary<string, bool>();

            for (var user = 1; user <= numberOfUsers; user++)
            {
                for (var thread = 1; thread <= numberOfThreads; thread++)
                {
                    usersHash.Add($"{user},{thread}", false);
                }
            }

            return usersHash;
        }

        public string GetRandomUserThread(Dictionary<string, bool> usersHash, bool predicate)
        {

            var notRanYet = usersHash.Where(entry => entry.Value == predicate).Select(entry => entry.Key).ToList();

            if (notRanYet.Count > 0)
            {
                return notRanYet[new Random().Next(notRanYet.Count - 1)];
            }

            return "";
        }
    }
}
