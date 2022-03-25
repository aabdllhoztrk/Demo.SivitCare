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
   public class TC7_GirenCikanSiviEkleSil : BaseTest
    {
        [Test]
        public void GirenSiviEkleSil()
        {
            LoginPage login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var sivigiren = homePage.SiviGirenSayfasinaGit();
            sivigiren.GirenSiviEkleSil();
            sivigiren.OralVerilenSiviEkleSil();
        }
        [Test]
        public void CikanSiviEkleSil()
        {
            LoginPage login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var sivicikan = homePage.SiviCikanSayfasinaGit();
            sivicikan.IdrarEkleSil();
            sivicikan.KusmaEkleSil();
            sivicikan.DefekasyonEkleSil();          
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
