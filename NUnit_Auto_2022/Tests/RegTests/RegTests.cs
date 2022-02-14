using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.Tests.RegTests
{
    class RegTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            var csvData = Utils.GetDataTableFromCsv("TestData1\\registration.csv");
            for (int i = 0; i < csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.GetGenericData("TestData1\\registration.csv"))
            {
                yield return new TestCaseData(values);
            }
        }


        [Test, TestCaseSource("GetCredentialsDataCsv2")]
        public void BasicRegistration(string username, string password, string confPassword, string firstName, string lastName, string email,
                             string usernameError, string passwordError, string confPasswordError, string fnameError, string lnameError, string emailError)
        {
            driver.Navigate().GoToUrl(url + "registration");
            PageModels.POM.RegistrationPage rp = new PageModels.POM.RegistrationPage(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Register(username, password, confPassword, firstName, lastName, email);

            Assert.AreEqual(usernameError, rp.GetUsernameErrorText());
            Assert.AreEqual(passwordError, rp.GetPasswordErrorText());
            Assert.AreEqual(confPasswordError, rp.GetConfPasswordErrorText());
            Assert.AreEqual(fnameError, rp.GetFirstNameErrorText());
            Assert.AreEqual(lnameError, rp.GetLastNameErrorText());
            Assert.AreEqual(emailError, rp.GetEmailErrorText());
        }
    }
}
