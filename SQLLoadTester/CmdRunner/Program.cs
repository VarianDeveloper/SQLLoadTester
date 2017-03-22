using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CmdRunner
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = @"select * from Person.Person";
            var runEvery = 1000; //1 sec
            var isRepeat = true;    //todo: change to defaulkt as false
            var stopAfter = 10;

            if (args.Length == 3)
            {

                command = args[0];
                runEvery = int.Parse(args[1]);
                isRepeat = int.Parse(args[2]) == 1;
                stopAfter = int.Parse(args[3]);

            }

            var myConnection = new SqlConnection("user id=sa;" +
                                       "password=service;server=ALEXHOME;" +
                                       "Trusted_Connection=yes;" +
                                       "database=AdventureWorks2012; " +
                                       "connection timeout=30");

            try
            {
                myConnection.Open();
                var myCommand = new SqlCommand(command, myConnection);

                while (isRepeat && stopAfter > 0)
                {
                    myCommand.ExecuteNonQuery();
                    stopAfter--;
                    Thread.Sleep(runEvery);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
