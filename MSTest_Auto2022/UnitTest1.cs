using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Auto_2022;
using System;

namespace MSTest_Auto2022
{
    [TestClass]
    public class UnitTest1
    {
        public object Calculator { get; private set; }

        [TestCleanup]
        public void SetUp()
        {
            Console.WriteLine("Before all test");
        }
        [TestMethod]
        [DataRow(100, 200, '+', 300)]
        //de continuat
        public void TestMethod1()
        {
            Console.WriteLine("Testing...");
            Calculator c = new Calculator(100, 200, '+');
            Assert.AreEqual(300, c.Compute());
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("After every test");
        }
    }
}
