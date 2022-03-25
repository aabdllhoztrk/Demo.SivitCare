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
    public class TC5_HizmetIsleme : BaseTest
    {
     /*   [Test]
        public void HastayaHizmetIsle() 
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hizmetIslemEPage = homePage.hizmetIslemeSayfasinaGit();
            hizmetIslemEPage.HastayaHizmetIsle();
        }
     */
        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
