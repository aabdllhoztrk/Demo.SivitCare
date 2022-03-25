using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.SivitCare.Selenium.BaseClass;
using Demo.SivitCare.Selenium.PageObject;

namespace Demo.SivitCare.Selenium.TestScript
{
    public class TC1_Login : BaseTest
    {
        [Test]

        public void Login()
        {
            var loginPage = new LoginPage(driver);
            var homePage = loginPage.LoginOlma();
            homePage.Cikis();
            Console.WriteLine("TC1_Login Basarili!!!");
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
