using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenisi
{
    public static class Browser
    {
        public static void Open(string url)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverStore.WebDriver = driver;
            WebDriverStore.WebDriver.Navigate().GoToUrl(url);
        }

        public static void Close()
        {
            WebDriverStore.WebDriver.Close();
        }
    }
}
