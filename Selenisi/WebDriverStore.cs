using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenisi
{
    class WebDriverStore
    {
        public static IWebDriver WebDriver { get; set; }

        public static void InitWebDriver()
        {
            WebDriver = new ChromeDriver();
        }
    }
}
