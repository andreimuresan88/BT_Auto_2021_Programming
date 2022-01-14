
using NUnit_Auto_2022;
using System;
using Xunit;

namespace XUnit_Auto_2022
{
    //public class UnitTest1 : IClassFixture<UnitTest1>
    public class UnitTest1 : IDisposable
    {
        public UnitTest1()
        {
            Console.WriteLine("Setup every test");
        }

        //[Fact] is for tests without parameters
        [Theory]
        [InlineData(50, 100, '-', -50)]
        public void Test1(double a, double b, char op, double res)
        {
            //de urmarit
            Calculator c = new Calculator(a, b, op);
            Assert.Equal(res, c.Compute());
        }

        public void SetUp()
        {

        }

        public void Dispose()
        {
            Console.WriteLine("TearDown!");
        }

        public void Test11()
        {
            Console.WriteLine();
            
        }
    }
}
