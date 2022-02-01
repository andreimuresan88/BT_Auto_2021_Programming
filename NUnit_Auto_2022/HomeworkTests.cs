using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnit_Auto_2022
{
    class HomeworkTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TestCase("abcd", "12345678", "12345678", "aa!!@!a", "aaa", "aaa@aa.ro", "", "", "", "","","")]
        [TestCase("abc", "12345678", "12345678", "aaa", "aaa", "aaa@aa.ro", "Minimum of 4 characters is required!", "", "", "","","")]
        [TestCase("123456789012345678901234567890123456789", "12345678", "12345678", "aaa", "aaa", "aaa@aa.ro", "Maximum of 35 characters allowed!", "", "", "","","")]
        [TestCase("abcd", "", "12345678", "aaa", "aaa", "aaa@aa.ro", "", "Password is required!", "Passwords do not match!", "","","")]
        [TestCase("abcd", "12345678", "1234567", "aaa", "aaa", "aaa@aa.ro", "", "", "Passwords do not match!", "","","")]
        [TestCase("abcd", "1234567", "12345678", "aaa", "aaa", "aaa@aa.ro", "", "Minimum of 8 characters is required!", "Passwords do not match!", "","","")]
        [TestCase("abcd", "12345678", "12345678", "a", "aaa", "aaa@aa.ro", "", "", "", "Minimum of 2 characters is required!", "","")]
        [TestCase("abcd", "12345678", "12345678", "aaa", "a", "aaa@aa.ro", "", "", "", "", "Minimum of 2 characters is required!", "")]
        [TestCase("abcd", "12345678", "12345678", "aaa", "aaa", "aaa@aa", "", "", "", "","", "Invalid email address!")]
        [TestCase("abcd", "12345678", "12345678", "aaa", "aaa", "aaaaa.ro", "", "", "", "","", "Invalid email address!")]
        [TestCase("abcd", "12345678", "12345678", "aaa", "aaa", "", "", "", "", "","", "Email is required!")]
        public void Test01(string user, string pass, string confPass, string fName, string lName, string emailAddress, string userError, string passError, string confPassError, string firstNameError, string lastNameError, string emailError)
        {
            driver.Navigate().GoToUrl(url);

            var registrationLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(3)"));
            registrationLink.Click();

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Registration", pageText.Text);

            var username = driver.FindElement(By.Id("input-username"));
            var usernameEmptyErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            
            var password = driver.FindElement(By.Id("input-password"));
            var passwordEmptyErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));

            var confirmPassword = driver.FindElement(By.Id("input-password-confirm"));
            var confirmPasswordErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));

            var firstName = driver.FindElement(By.Id("input-first-name"));
            var firstNameErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));

            var lastName = driver.FindElement(By.Id("input-last-name"));
            var lastNameErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));

            var email = driver.FindElement(By.Id("input-email"));
            var emailErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));

            var title = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            title.Click();

            var dateOfBirth = driver.FindElement(By.Id("input-dob"));
            dateOfBirth.Click();
            var selectDate = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(10) > div > div > div.react-datepicker__tab-loop > div.react-datepicker-popper > div > div > div.react-datepicker__month-container > div.react-datepicker__month > div:nth-child(4) > div.react-datepicker__day.react-datepicker__day--017"));
            selectDate.Click();

            var nationality = driver.FindElement(By.Id("input-nationality"));
            nationality.Click();
            var nationalitySelect = driver.FindElement(By.CssSelector("#input-nationality > option:nth-child(83)"));
            nationalitySelect.Click();

            var terms = driver.FindElement(By.Id("terms"));
            terms.Click();

            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            confirmPassword.Clear();
            confirmPassword.SendKeys(confPass);

            firstName.Clear();
            firstName.SendKeys(fName);

            lastName.Clear();
            lastName.SendKeys(lName);

            email.Clear();
            email.SendKeys(emailAddress);

            submit.Submit();

            Assert.AreEqual(userError, usernameEmptyErr.Text);
            Assert.AreEqual(passError, passwordEmptyErr.Text);
            Assert.AreEqual(confPassError, confirmPasswordErr.Text);
            Assert.AreEqual(firstNameError, firstNameErr.Text);
            Assert.AreEqual(lastNameError, lastNameErr.Text);
            Assert.AreEqual(emailError, emailErr.Text);

            //Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch("nimic", "[A-Za-z-]"));
        }

/*      - identify the buttons in the page - done

        - generate a cookie using the button - done

        - get the cookies from the browser using the code - done

        - get the text from the page with the cookie value - done

        - verify that the cookie text from the page is the same as the cookie value from the browser - done

        - delete the cookie using the button - done

        - check that the cookie is no longer present*/

        [Test]
        public void Test02()
        {
            driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/cookie");

            var setCookieBtn = driver.FindElement(By.Id("set-cookie"));
            var deleteCookieBtn = driver.FindElement(By.Id("delete-cookie"));

            setCookieBtn.Click();

            var getCookies = driver.Manage().Cookies;
            var cookieValue = driver.FindElement(By.Id("cookie-value"));
            Console.WriteLine("cookieValue" + cookieValue);
            var ck = getCookies.GetCookieNamed("gibberish").Value;
            Console.WriteLine("ck : " + ck);

            Assert.AreEqual(cookieValue.Text, ck);

            //deleteCookieBtn.Click();

            var deletedCookie = getCookies.GetCookieNamed("gibberish");
            
            Assert.IsNull(deletedCookie);


        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
