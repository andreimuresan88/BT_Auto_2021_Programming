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

        [Fact]
        public void Test1()
        {

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
            Calculator c
        }
    }
}
