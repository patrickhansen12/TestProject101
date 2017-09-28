using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class Proposal
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Proposal> proposalList = new List<Proposal>();
            {
                proposalList.Add(new Proposal());
                proposalList.Add(new Proposal());
            }
            Assert.AreEqual(proposalList.Count, 2);
        }
    }
}
