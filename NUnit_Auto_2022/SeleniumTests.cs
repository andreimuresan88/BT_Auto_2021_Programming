using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests
    {

        //public string path = "C:\\Users\\Muresan\\Desktop\\drivers";
        IWebDriver driver;
        const string protocol = "https";
        //const string hostname = "google.com";
        const string hostname = "magazinulcolectionarului.ro";
        const string path = "/";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            //driver = new EdgeDriver();
        }

        [Test]
        public void Test1()
        {
            //driver.Url = "https://google.com";
            driver.Url = url;
            driver.Navigate();

            //sau

            //driver.Navigate().GoToUrl(url);

            driver.Navigate().Back();//controleaza butonul de back din chrome

            driver.Navigate().Forward();

            driver.Navigate().Refresh();
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://learn.digitalstack.ro";
            driver.Navigate();
        }
        [Test]
        public void Test3()
        {
            driver.Url =url;
            driver.Navigate();
/*            IWebElement cookieAccept = driver.FindElement(By.ClassName("model-header"));
            cookieAccept.Click();
            IWebElement eaglemoss = driver.FindElement(By.XPath("//*[@id='ui - id - 2']"));

            eaglemoss.Click();*/

            IWebElement body = driver.FindElement(By.ClassName("modal-header"));
            body.Click();

            IWebElement eaglemoss = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/nav/div/ul/li[1]/a/span[2]"));
            eaglemoss.Click();

            var addToCart = driver.FindElements(By.XPath("partea comuna din xpath"));
            foreach(IWebElement el in addToCart)
            {
                var text = el.FindElement(By.XPath("cautam dupa specificul elementului"));
                Console.WriteLine(text.Text);
            }
        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            driver.Quit();
        }

    }
}
