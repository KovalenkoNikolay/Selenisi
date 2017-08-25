using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenisi
{
    public class By
    {
        internal string Locator;

        public static By Id(string id)
        {
            return new By
            {
                Locator = id
            };
        }
    }
}
