using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenisi
{
    public class SWebElement
    {
        private static IWebElement _seleniumWebElement;

        public SWebElement(IWebElement seleniumElement)
        {
            _seleniumWebElement = seleniumElement;
        }

        public string Text
        {
            get { return _seleniumWebElement.Text; }
        }
    }
}
