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
        const string authentificationTextSelector = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > h1"; //css
        const string firstNameLabelSelector = "#register > formfield > div:nth-child(3) > label"; //css
        const string firstNameInputSelector = "newfirstname"; //id
        const string lastNameLabelSelector = "#register > formfield > div:nth-child(4) > label";//css
        const string lastNameInputSelector = "newlastname";//id
        const string phoneNumberLabelSelector = "#register > formfield > div:nth-child(5) > label";//css
        const string phoneNumberInputSelector = "telephone";//id
        const string emailLabelSelector = "#register > formfield > div:nth-child(6) > label";//css
        const string emailInputSelector = "newemail";//id
        const string passwordLabelSelector = "#register > formfield > div:nth-child(7) > label";//css
        const string passwordInputSelector = "newpassword";//id
        const string passwordConfirmationLabelSelector = "#register > formfield > div:nth-child(8) > label";//css
        const string passwordConfirmationInpustSelector = "newpasswordretype"; //id
        const string newsletterCheckBoxSelector = "newsletter"; //id
        const string termsAndCondCheckBoxSelector = "agree";//id
        const string submitRegistrationButtonSelector = "#register > formfield > div:nth-child(9) > div > button";//css
        const string userIsAlreadyLoggedInMessSelector = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li";

        const string emailErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(1)";//css
        const string passwordErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(2)";//css
        const string passwordConfirmationErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(3)";//css
        const string firstNameErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(4)";//css
        const string lastNmaeErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(5)";//css
        const string phoneNumberErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(6)";//css
        const string termsAndCondErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(7)";//css

        const string loginEmailLabelSelector = "#login > formfield > div:nth-child(3) > label"; //css
        const string loginEmailInputSelector = "email"; //id
        const string loginPasswordLabelSelector = "#login > formfield > div:nth-child(4) > label";//css
        const string loginPasswordInputSelector = "password";//id
        const string forgotPasswordLinkSelector = "#login > formfield > div:nth-child(4) > div > a";//css
        const string submitLoginButtonSelector = "#login > formfield > div:nth-child(5) > div > button";//css
        const string loginErrorMess = "#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(3)";//css
        
        

        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "www.vexio.ro";
        const string path = "/account/login/";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase("", "", "", "", "", "",
                  "Va rugam sa completati prenumele dvs.",
                  "Va rugam sa completati numele dvs.",
                  "Va rugam sa completati numarul dvs. de telefon",
                  "Va rugam sa completati adresa dvs. de e-mail",
                  "Va rugam sa completati parola",
                  "Va rugam reintroduceti parola")]
        public void Test01(string fname, string lname, string phone, string email, string pass, string confpass,
                           string fnameErr, string lnameErr, string phoneErr, string emailErr, string passErr, string confpassErr)
        {
            driver.Navigate().GoToUrl(url);

            var cookie = driver.FindElement(By.CssSelector("#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button > span"));
            cookie.Click();

            var firstName = driver.FindElement(By.Id(firstNameInputSelector));
            
            firstName.Clear();
            firstName.SendKeys(fname);

            var lastName = driver.FindElement(By.Id(lastNameInputSelector));
            lastName.Clear();
            lastName.SendKeys(lname);


            var phoneNumber = driver.FindElement(By.Id(phoneNumberInputSelector));
            phoneNumber.Clear();
            phoneNumber.SendKeys(phone);

            var emailAddress = driver.FindElement(By.Id(emailInputSelector));
            emailAddress.Clear();
            emailAddress.SendKeys(email);

            var password = driver.FindElement(By.Id(passwordInputSelector));
            password.Clear();
            password.SendKeys(pass);

            var passwordConfirmation = driver.FindElement(By.Id(passwordConfirmationInpustSelector));
            passwordConfirmation.Clear();
            passwordConfirmation.SendKeys(confpass);

            var terms = driver.FindElement(By.Id(termsAndCondCheckBoxSelector));
            terms.Click();

            var submit = driver.FindElement(By.CssSelector(submitRegistrationButtonSelector));
            submit.Submit();

            var firstNameEmptyErr = driver.FindElement(By.CssSelector(firstNameErrorMess));
            var lastNameEmptyErr = driver.FindElement(By.CssSelector(lastNmaeErrorMess));
            var phoneNumberEmptyErr = driver.FindElement(By.CssSelector(phoneNumberErrorMess));
            var emailAddressEmptyErr = driver.FindElement(By.CssSelector(emailErrorMess));
            var passwordEmptyErr = driver.FindElement(By.CssSelector(passwordErrorMess));
            var passwordConfirmationEmptyErr = driver.FindElement(By.CssSelector(passwordConfirmationErrorMess));


            Assert.AreEqual(fnameErr, firstNameEmptyErr.Text);
            Assert.AreEqual(lnameErr, lastNameEmptyErr.Text);
            Assert.AreEqual(phoneErr, phoneNumberEmptyErr.Text);
            Assert.AreEqual(emailErr, emailAddressEmptyErr.Text);
            Assert.AreEqual(passErr, passwordEmptyErr.Text);
            Assert.AreEqual(confpassErr, passwordConfirmationEmptyErr.Text);
        }

        [TestCase("abcdefg", "abcdefg", "1234567891", "abcdefg@abc.ro", "12345678", "12345678", "Deja exista un cont inregistrat cu aceasta adresa de email. Va rugam sa alegeti Sunt deja client sau Am uitat parola. Puteti de asemenea sa completati o alta adresa de email.")]

        public void Test02(string fname, string lname, string phone, string email, string pass, string confpass, string errorMess)
        {
            driver.Navigate().GoToUrl(url);

            var cookie = driver.FindElement(By.CssSelector("#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button > span"));
            cookie.Click();

            var firstName = driver.FindElement(By.Id(firstNameInputSelector));
            firstName.Clear();
            firstName.SendKeys(fname);

            var lastName = driver.FindElement(By.Id(lastNameInputSelector));
            lastName.Clear();
            lastName.SendKeys(lname);

            var phoneNumber = driver.FindElement(By.Id(phoneNumberInputSelector));
            phoneNumber.Clear();
            phoneNumber.SendKeys(phone);

            var emailAddress = driver.FindElement(By.Id(emailInputSelector));
            emailAddress.Clear();
            emailAddress.SendKeys(email);

            var password = driver.FindElement(By.Id(passwordInputSelector));
            password.Clear();
            password.SendKeys(pass);

            var passwordConfirmation = driver.FindElement(By.Id(passwordConfirmationInpustSelector));
            passwordConfirmation.Clear();
            passwordConfirmation.SendKeys(confpass);

            var newsletter = driver.FindElement(By.Id(newsletterCheckBoxSelector));
            newsletter.Click();

            var terms = driver.FindElement(By.Id(termsAndCondCheckBoxSelector));
            terms.Click();

            var submit = driver.FindElement(By.CssSelector(submitRegistrationButtonSelector));
            submit.Submit();

            var errorMessaAfterSubmit = driver.FindElement(By.CssSelector(userIsAlreadyLoggedInMessSelector));

            Assert.AreEqual(errorMess, errorMessaAfterSubmit.Text);
        }

        [TestCase("", "", "Parola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        //[TestCase("abcdefg", "", "Parola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        //[TestCase("", "abcdefg", "Parola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        public void Test03(string userEmail, string userPassword, string messErrorToLogIn)
        {
            driver.Navigate().GoToUrl(url);

            var cookie = driver.FindElement(By.CssSelector("#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button > span"));
            cookie.Click();

            var user = driver.FindElement(By.Id(loginEmailInputSelector));
            user.Clear();
            user.SendKeys(userEmail);

            var password = driver.FindElement(By.Id(loginPasswordInputSelector));
            password.Clear();
            password.SendKeys(userPassword);

            var loginButton = driver.FindElement(By.CssSelector(submitLoginButtonSelector));
            loginButton.Submit();

            var error = driver.FindElement(By.CssSelector(loginErrorMess));
            
            Assert.AreEqual(messErrorToLogIn, error.Text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
