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
   public class TC3_VitalBulguEkleSil : BaseTest
    {
        [Test]
        public void VitalEkleSil()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var vitalBulgular = homePage.vitalBulgularSayfasinaGit();
            vitalBulgular.VitalEkle();
            vitalBulgular.ValidateVitalBulgular();
            vitalBulgular.VitalSil();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
