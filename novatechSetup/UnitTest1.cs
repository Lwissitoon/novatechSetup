namespace novatechSetup
{
    public class Tests:Hooks
    {


        [Test]
        [TestCase("standard_user", "secret_sauce")]
        public void Test1(string username, string password)
        {
            App.login.GetUsername().SendKeys(username);
            App.login.GetPassword().SendKeys(password);
            App.login.GetLoginBtn().Click();
            Thread.Sleep(10000);
            Assert.IsTrue(App.driver.Url == "https://www.saucedemo.com/inventory.html");
        }

        [Test]
        [TestCase("standard_user", "secret_sauce", "lohi")]
        public void Test2(string username, string password,string value)
        {
            App.login.GetUsername().SendKeys(username);
            App.login.GetPassword().SendKeys(password);
            App.login.GetLoginBtn().Click();

            Assert.IsTrue(App.driver.Url == "https://www.saucedemo.com/inventory.html");


        }
    }
}