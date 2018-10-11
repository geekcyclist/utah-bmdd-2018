using System;
using Conditionals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConditionalsTests
{
    [TestClass]
    public class MovementTests
    {
        [DataTestMethod]
        [DataRow("Up","Moved Up")]
        [DataRow("Down", "Moved Down")]
        [DataRow("Left", "Moved Left")]
        [DataRow("Right", "Moved Right")]
        public void MoveTest(string direction, string expected)
        {
            Assert.AreEqual(expected, Conditionals.Movement.Move(direction));
        }
    }
}
