using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NUnit_Homework_2022.Utils
{
    public class Utils
    {
        public static IWebElement WaitForElement(IWebDriver driver, int seconds, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebDriver WaitForFluentElement(IWebDriver driver, int seconds, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Message = "Sorry !! The element in the page cannot be found!"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return (IWebDriver)fluentWait.Until(x => x.FindElement(locator));
        }

        public static void PrintCookie(ICookieJar cookies)
        {
            foreach(Cookie cookie in cookies.AllCookies)
            {
                Console.WriteLine("Cookie name {0} - cookie value {1}", cookie.Name, cookie.Value);
            }
        }

        public static void TakeScreenShotWithDate(IWebDriver driver, string path, string filename, ScreenshotImageFormat format)
        {
            DirectoryInfo validator = new DirectoryInfo(path);
            if (!validator.Exists)
            {
                validator.Create();
            }

            string currentDate = DateTime.Now.ToString();
            StringBuilder sb = new StringBuilder(currentDate);
            sb.Replace(":", "_");
            sb.Replace(".", "_");
            sb.Replace(" ", "_");
            string finalFilePath = String.Format("{0}\\{1}_{2}.{3}", path, filename, currentDate, format);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(finalFilePath, format);
        }

        public static void ExecuteJsScript(IWebDriver driver, string script)
        {
            var jsExecutor = (IJavaScriptExecutor)driver;
            var result = jsExecutor.ExecuteScript(script);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
        }

        public static Dictionary<string, string> ReadConfig(string configFilePath)
        {
            var configData = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(configFilePath))
            {
                string[] values = line.Split('=');
                configData.Add(values[0].Trim(), values[1].Trim());
            }
            return configData;
        }

    }
}
