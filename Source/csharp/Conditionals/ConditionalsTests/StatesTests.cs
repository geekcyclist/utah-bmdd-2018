using System;
using Conditionals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConditionalsTests
{
    [TestClass]
    public class StatesTests
    {
        [DataTestMethod]
        [DataRow("Utah", "UT")]
        [DataRow("Wyoming", "WY")]
        public void CanGetStateAb(string actual, string expected)
        {
            Assert.AreEqual(expected, States.chkState(actual));
        }
    }
}
