using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenisi;
using static Selenisi.Common;

namespace SelenisiTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Open("https://luis-goncalves.com/agile-retrospectives-antipatterns/?utm_campaign=Ads&utm_source=facebook.com&utm_medium=social");
            
            //Open("http://google.com");

            var i = E(By.Id("seattle-button-yes")).Text;
            var y = E(By.Id("seattle-button-no")).Text;
            Quit();
        }
    }
}
