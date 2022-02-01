using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite
    {
        //https://www.abdcomputer.ro/
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

/*        [Test]
        public void LoginTest()
        {
            LandingPage lp = new LandingPage(driver);
            Assert.AreEqual("Produse IT Renew, Refurbish, Noi & SH", lp.CheckPage());
            lp.LogInNavigate();
        }*/

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
