using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise02;
using Exercise01;
namespace UnitTestExercise02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidInput()
        {
            string number = "20000";
            number = BigIntExtenderLibrary.Towards(double.Parse(number));
            Assert.IsNotNull("Twenty Thousand");
        }
    }
}
