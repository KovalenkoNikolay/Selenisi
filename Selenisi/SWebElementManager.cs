using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenisi
{
    public static class SWebElementManager
    {
        public static SWebElement GetSWebElement(By seleniumSelector)
        {
            return new SWebElement(WebDriverManager.WebDriver.FindElement(SelectorManager.GetSeleniumById(seleniumSelector)));
        }
    }
}
