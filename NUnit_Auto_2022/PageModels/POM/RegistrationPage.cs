using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace NUnit_Auto_2022.PageModels.POM
{
    class RegistrationPage : BasePage
    {
        const string registrationPageText = "#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"; //css
        const string usernameInputSelector = "input-username"; //id
        const string usernameInputErrorMess = "#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"; //css
        const string passwordInputSelector = "input-password"; //id
        const string passwordInputErrorMess = "#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"; //css
        const string confirmPasswordInputSelector = "input-password-confirm"; //id
        const string confirmPasswordInputErrorMess = "#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";//css
        const string firstNameInputSelector = "input-first-name"; //id
        const string firstNameInputErrorMess = "#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"; //css
        const string lastNameInputSelector = "input-last-name"; //id
        const string lastNameInputErrorMess = "#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"; //css
        const string emailInputSelector = "input-email"; //id
        const string emailInputErrorMess = "#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"; //css
        const string titleRadioBtnSelector = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"; //css
        const string dateOfBirthInputSelector = "input-dob"; //id
        const string selectADateOfBirthFromCalendar = "#registration-form > div:nth-child(10) > div > div > div.react-datepicker__tab-loop > div.react-datepicker-popper > div > div > div.react-datepicker__month-container > div.react-datepicker__month > div:nth-child(5) > div.react-datepicker__day.react-datepicker__day--028"; //css
        const string nationalityInputSelector = "input-nationality"; //id
        const string nationalityPickerSelector = "#input-nationality > option:nth-child(83)";//css
        const string termAndCondInputSelector = "terms"; //id
        const string submitButtonInputSelector = "#registration-form > div:nth-child(13) > div.text-left.col-lg > button";//css
        
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage() //GetRegisterLabel
        {
            var registerPageElement = driver.FindElement(By.CssSelector(registrationPageText));
            return registerPageElement.Text;
        }

        public void Register(string username, string password, string confPassword, string fname, string lname, string email)//, 
                             //string usernameError, string passwordError, string confPasswordError, string fnameError, string lnameError, string emailError)
        {
            var usernameInputElement = driver.FindElement(By.Id(usernameInputSelector));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(username);
            
            var passwordInputElement = driver.FindElement(By.Id(passwordInputSelector));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(password);

            var confirmPasswordInputElement = driver.FindElement(By.Id(confirmPasswordInputSelector));
            confirmPasswordInputElement.Clear();
            confirmPasswordInputElement.SendKeys(confPassword);

            var firstNameInputElement = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInputElement.Clear();
            firstNameInputElement.SendKeys(fname);

            var lastNameInputElement = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInputElement.Clear();
            lastNameInputElement.SendKeys(lname);

            var emailInputElement = driver.FindElement(By.Id(emailInputSelector));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);

            var titleInputElement = driver.FindElement(By.CssSelector(titleRadioBtnSelector));
            titleInputElement.Click();

            var dateOfBirthElement = driver.FindElement(By.Id(dateOfBirthInputSelector));
            dateOfBirthElement.Click();
            var selectDateOfBirthElement = driver.FindElement(By.CssSelector(selectADateOfBirthFromCalendar));
            selectDateOfBirthElement.Click();

            var nationalityInputElement = driver.FindElement(By.Id(nationalityInputSelector));
            nationalityInputElement.Click();
            var nationalityPickerInputElement = driver.FindElement(By.CssSelector(nationalityPickerSelector));
            nationalityPickerInputElement.Click();

            var termsAndCondInputElement = driver.FindElement(By.Id(termAndCondInputSelector));
            termsAndCondInputElement.Click();

            //var usernameErrorElement = driver.FindElement(By.CssSelector(usernameInputErrorMess));
            //var passwordErrorElement = driver.FindElement(By.CssSelector(passwordInputErrorMess));
            //var confPasswordErrorElement = driver.FindElement(By.CssSelector(confirmPasswordInputErrorMess));
            //var firstNameErrorElement = driver.FindElement(By.CssSelector(firstNameInputErrorMess));
            //var lastNameErrorElement = driver.FindElement(By.CssSelector(lastNameInputErrorMess));
            //var emailErrorElement = driver.FindElement(By.CssSelector(emailInputErrorMess));

            var submitInputElement = driver.FindElement(By.CssSelector(submitButtonInputSelector));
            submitInputElement.Submit();
        }

        public string GetUsernameErrorText() 
        {
            var usernameErrorElement = driver.FindElement(By.CssSelector(usernameInputErrorMess));
            return usernameErrorElement.Text;
            //return driver.FindElement(By.CssSelector(usernameInputErrorMess)).Text;
        }

        public string GetPasswordErrorText() 
        {
            var passwordErrorElement = driver.FindElement(By.CssSelector(passwordInputErrorMess));
            return passwordErrorElement.Text;
        }
        public string GetConfPasswordErrorText()
        {
            var confPasswordErrorElement = driver.FindElement(By.CssSelector(confirmPasswordInputErrorMess));
            return confPasswordErrorElement.Text;
        }

        public string GetFirstNameErrorText()
        {
            var firstNameErrorElement = driver.FindElement(By.CssSelector(firstNameInputErrorMess));
            return firstNameErrorElement.Text;
        }

        public string GetLastNameErrorText()
        {
            var lastNameErrorElement = driver.FindElement(By.CssSelector(lastNameInputErrorMess));
            return lastNameErrorElement.Text;
        }

        public string GetEmailErrorText()
        {
            var emailErrorElement = driver.FindElement(By.CssSelector(emailInputErrorMess));
            return emailErrorElement.Text;
        }

    }
}
