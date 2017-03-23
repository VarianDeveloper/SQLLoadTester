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
            string defaultCommand = "select * from pt";

            if (args.Length > 0)
            {
                Console.WriteLine("No params specified, using defaults...");
                defaultUsersNumber = int.Parse(args[0]);
            }

            //            for (var i = 0; i < defaultUsersNumber; i++)
            //            {
            //run command in endless loop with intervals of 1 sec
            new ThreadRunners.SqlCommands().RunSqlCmdThread(defaultCommand, defaultUsersNumber, defaultThreadsPerUser);
            //  }
        }
    }
}
