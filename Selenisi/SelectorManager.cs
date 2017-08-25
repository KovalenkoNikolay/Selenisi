using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenisi
{
    class SelectorManager
    {
        public static OpenQA.Selenium.By GetSeleniumById(By selenisiBy)
        {
            return OpenQA.Selenium.By.Id(selenisiBy.Locator);
        }
    }
}
