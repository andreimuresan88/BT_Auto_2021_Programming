using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class Browser
    {
        public static IWebDriver GetDriver(WebBrowsers browserType)
        {
            switch (browserType)
            {
                case WebBrowsers.Chrome:
                    {
                        return new ChromeDriver();
                    }
                case WebBrowsers.Firefox:
                    {
                        return new FirefoxDriver();
                    }
                case WebBrowsers.Edge:
                    {
                        return new EdgeDriver();
                    }
                default:
                    {
                       return null;
                    }

            }
        }
     

        }
    }

    public enum WebBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }

