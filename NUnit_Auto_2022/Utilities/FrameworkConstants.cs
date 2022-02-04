using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    class FrameworkConstants
    {
        static Dictionary<string, string> configData = Utils.ReadConfig("config.properties");

        const string extensionPath = "Other\\ExtensionFile";

        static string protocol = configData["protocol"];
        static string hostname = configData["hostname"];
        static string port = configData["port"];
        static string path = configData["apppath"];
        public static string browserProxy = configData["proxyserver"];
        public static bool startHeadLess = GetHeadLessConfig();
        public static bool useProxy = Boolean.Parse(configData["useproxy"]);
        public static bool startMaximized = Boolean.Parse(configData["statmaximized"]);
        public static bool ignoreCertErr = Boolean.Parse(configData["ignorecerterr"]);
        public static bool startWithExtension = Boolean.Parse(configData["extension"]);
        public static string configBrowser = configData["browser"];
        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }

        public static string GetExtensionName(WebBrowsers browserType)
        {
            switch (browserType)
            {
                case WebBrowsers.Firefox:
                    {
                        return String.Format("{0}\\metamask-10.8.1-an+fx.xpi", extensionPath);
                    }
                default:
                    {
                        return String.Format("{0}\\extension_4_42_0_0.crx", extensionPath);
                    }
            }
        }

        private static bool GetHeadLessConfig()
        {
            foreach(KeyValuePair<string, string>kvp in Environment.GetEnvironmentVariables())
            {
                if (kvp.Key.Equals("env"))
                {
                    if (!kvp.Value.Equals("local"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return Boolean.Parse(configData["headless"]);
        }
    }
}
