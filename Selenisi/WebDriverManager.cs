using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenisi
{
    static class WebDriverManager
    {
        private static IWebDriver _webDriver;

        public static IWebDriver WebDriver
        {
            get { return _webDriver ?? (_webDriver = WebDriverRunner.StartWebDriver()); }
            set { _webDriver = value; }
        }
    }
}
