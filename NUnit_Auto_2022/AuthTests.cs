using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthTests
    {

        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "";
        const string port = "4999";
        const string path = "/#login";

        string url = protocol + "://" + hostname + port + path;
    }

/*    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void Test01()
    {

    }*/
}
