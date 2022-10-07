using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novatechSetup
{
    public class Hooks
    {
        [SetUp]
        public void Setup()
        {

            App.InitDriver("https://www.saucedemo.com/");
        }


        [TearDown]
        public void Teardown()
        {
            App.CloseDriver();
        }
    }
}
