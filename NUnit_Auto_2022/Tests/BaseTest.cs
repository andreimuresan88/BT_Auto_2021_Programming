using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class BaseTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Browser.GetDriver(WebBrowsers.Chrome);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
