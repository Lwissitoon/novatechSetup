using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V101.CSS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novatechSetup
{
    public class Extension
    {
       static SelectElement SelectorList;

        public static void SelectValueFromSelect(IWebElement element,string value)
        {
            SelectorList = new SelectElement(element);
            SelectorList.SelectByValue(value);
        }
    }
}
