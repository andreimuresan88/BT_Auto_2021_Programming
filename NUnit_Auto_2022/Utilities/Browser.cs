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

        public static IWebDriver GetDriver()
        {
            WebBrowsers cfgBrowser;
            switch (FrameworkConstants.configBrowser.ToUpper())
            {
                case "FIREFOX":
                    {
                        cfgBrowser = WebBrowsers.Firefox;
                        break;
                    }
                case "CHROME":
                    {
                        cfgBrowser = WebBrowsers.Chrome;
                        break;
                    }
                case "EDGE":
                    {
                        cfgBrowser = WebBrowsers.Edge;
                        break;
                    }
                default:
                    {
                        throw new BrowerTypeException(String.Format(""));
                    }
            }
            return GetDriver(cfgBrowser);
        }
     

        }
    }

    public enum WebBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }

