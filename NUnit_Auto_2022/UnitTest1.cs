using NUnit.Framework;
using System;

namespace NUnit_Auto_2022
{
    [TestFixture(15, 35)]
    [TestFixture(25, 22)]
    public class Tests
    {
        int x;
        int y;
        public Tests(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        [OneTimeSetUp]
        public void SetUpOnce()
        {
            TestContext.Out.WriteLine("this method runs onli once for all tests");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("run me at every test!!");
            //conesiune cu browserul punem in aceasta metoda
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test(Description = "Test2 with 2 numbers")]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Console.WriteLine("first value is {0}, second value is {1} ", x, y);
        }

        [TestCase(69, 24, 199)]
        [TestCase(-100, -200, -300)]
        public void Test3(int a, int b ,int c)
        {
            Console.WriteLine("the sum is {0}", a + b + c + x + y);
            //Assert.AreEqual(-583, a + b + c + x + y, 0, "the test failed");
            //Assert.That(a, Is.AtLeast(100));
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Let's do some cleanup for every test!!");
            //inchidem browserul
        }

        [OneTimeTearDown]
        public void GeneralCleanUp()
        {
            TestContext.Out.WriteLine("is the final ... cleanup !!!");
        }
    }
}