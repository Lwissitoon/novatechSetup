using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novatechSetup.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        IWebElement Username => driver.FindElement(By.Id("user-name"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));

        public IWebElement GetUsername()
        {
            return Username;
        }

        public IWebElement GetPassword()
        {
            return Password;
        }

        public IWebElement GetLoginBtn()
        {
            return LoginBtn;
        }
    }
}
