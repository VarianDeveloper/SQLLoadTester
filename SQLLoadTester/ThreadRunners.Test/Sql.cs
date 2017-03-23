using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThreadRunners.Test
{
    [TestClass]
    public class Sql
    {
        private Dictionary<string, bool> uh;
        [TestInitialize]
        public void Init()
        {
            uh = new Dictionary<string, bool>()
            {
                {"1,1", false },
                {"1,2", false },
                {"1,3", false }
            };
        }

        [TestMethod]
        public void MustBeEmpty()
        {
            uh["1,1"] = true;
            uh["1,2"] = true;
            uh["1,3"] = true;

            Assert.IsTrue(new SqlCommands().GetRandomUserThread(uh, false).Equals(""));
        }

        [TestMethod]
        public void MustBeNotEmpty()
        {
            Assert.IsTrue(!new SqlCommands().GetRandomUserThread(uh, false).Equals(""));
        }

        [TestMethod]
        public void MustBeSpecificResult()
        {
            uh["1,1"] = true;
            uh["1,2"] = true;
            Assert.IsTrue(new SqlCommands().GetRandomUserThread(uh, false).Equals("1,3"));
        }
    }
}
