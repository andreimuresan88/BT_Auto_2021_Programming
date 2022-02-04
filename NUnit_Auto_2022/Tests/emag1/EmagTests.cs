using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests.emag1
{
    class EmagTests :BaseTest
    {
        [Test]
        public void Test01()
        {
            driver.Navigate().GoToUrl("https://emag.ro");
        }
    }
}
