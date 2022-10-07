using novatechSetup.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novatechSetup
{
    public static class App
    {
      public static  IWebDriver driver;
      public static LoginPage login;
        public static void InitDriver(string url)
        {
            driver = new ChromeDriver();

            driver.Url = url;
            InitPageObjects();  
        }

        public static void CloseDriver()
        {

            driver.Quit();  

        }

        public static void InitPageObjects()
        {
            login = new LoginPage(driver);
        }
    }
}
