using Demo.SivitCare.PageObject;
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
   public class TC8_KanGazlariEkleSil : BaseTest
    {
        [Test]
        public void KanGaziEklemeSilme() 
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage= loginPage.LoginOlma();
            KanGazlariPage kanGazlariPage= homePage.KanGazlariSayfasinaGit();
            kanGazlariPage.KanGazlariEkleSil();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
