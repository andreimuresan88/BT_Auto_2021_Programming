using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnit_Auto_2022
{
    class AuthTests
    {

        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        //const string path = "/#/login";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase("dinosaur", "dinosaurpassword", "","")]
        [TestCase("dinosaur", "", "", "Password is required")]
        [TestCase("", "", "Username is required", "Password is required")]
        [TestCase("", "dinopass", "Username is required", "")]
        public void Test01(string user, string pass, string userErr, string passwordErr)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            //recomandare, sa verificam ca suntem pe pagina buna
            //Assert.AreEqual("Authentication", pageText.Text);
            Assert.AreEqual("Home", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passwordErr, passwordError.Text);
        }


        //implicit wait test
        [Test]
        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            string url = protocol + "://" + hostname + ":" + "8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();

        }

        //explicit wait test
        [Test]
        public void Test03()
        {
            string url = protocol + "://" + hostname + ":" + "8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //var button1 = driver.FindElement(By.Id("btn1"));
            //IWebElement myDynamicElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btn1")));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();
        }

        [Test]
        public void Test04()
        {
            string url = protocol + "://" + hostname + ":" + "8081/lazy.html";
            driver.Navigate().GoToUrl(url);
            var button2 = Utils.WaitForElement(driver, 20, By.Id("btn2"));
            for(int i = 0; i<100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(20000); //do not use
        }

        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":" + "8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();
        }
        [Test]
        public void Test06()
        {
            driver.Navigate().GoToUrl("magazinul colectionerulu");
            var cookies = driver.Manage().Cookies;
            Console.WriteLine("the site contains {0}, cookies ", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            Cookie myCookie = new Cookie("myCookie", "vineoaiapapalupu");
            cookies.AddCookie(myCookie);
            Utils.PrintCookies(cookies);

            cookies.DeleteAllCookies();

            var ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("punem calea unde vrem sa ne salveze printscreenurile (calea full)", ScreenshotImageFormat.Png);

            Utils.TakeScreenShotWithDate(driver, "C\\:Temp", "screenshot1.png", ScreenshotImageFormat.Png);

        }

        [Test]
        public void Test07()
        {
            driver.Navigate().GoToUrl("punem pagina de alete");
            var alertButton = driver.FindElement(By.Id("alert-trigger"));
            var confirmButton = driver.FindElement(By.Id("confirm-trigger"));
            var promptButton = driver.FindElement(By.Id("prompt-trigger"));

            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();

            confirmButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();


            promptButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("alex");
            alert.Accept();
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
