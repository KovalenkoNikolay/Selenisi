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
    public static class Common
    {

        public static void Open(string url)
        {
            WebDriverManager.WebDriver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            WebDriverManager.WebDriver.Quit();
            WebDriverManager.WebDriver = null;
        }

        public static SWebElement E(By seleniumSelector)
        {
            return SWebElementManager.GetSWebElement(seleniumSelector);
        }
    }
}
