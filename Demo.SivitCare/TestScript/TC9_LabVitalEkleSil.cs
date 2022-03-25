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
   public class TC9_LabVitalEkleSil :BaseTest
    {
        [Test]
        public void LabVitalEklemeSilme()        
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage= loginPage.LoginOlma();
            LaboratuvarVitalPage laboratuvarVitalPage= homePage.VitalAltindaLabSayfasinaGit();
            laboratuvarVitalPage.LabDataEkleSil();
        }

        [TearDown]
        public void CloseWindow() 
        {
            driver.Quit();
        }
    }
}
