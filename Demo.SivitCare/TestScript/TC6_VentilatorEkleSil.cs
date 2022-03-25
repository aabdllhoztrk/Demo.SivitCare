using Demo.SivitCare.Selenium.BaseClass;
using Demo.SivitCare.Selenium.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.Selenium.TestScript
{
   public class TC6_VentilatorEkleSil: BaseTest
    {
        [Test]
        public void VentilatorEklemeSilme() 
        {
            LoginPage login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var ventilatorPage = homePage.ventilatorSayfasinaGit();
            ventilatorPage.VenlilatorEkle();
            ventilatorPage.VentilatorSil();

        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
