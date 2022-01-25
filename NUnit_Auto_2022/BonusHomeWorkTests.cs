using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class BonusHomeWorkTests
    {
        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "www.vexio.ro";
        const string path = "/account/login/#login";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test01()
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
