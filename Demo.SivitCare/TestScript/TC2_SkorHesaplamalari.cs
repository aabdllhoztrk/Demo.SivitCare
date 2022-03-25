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
    public class TC2_SkorHesaplamlari : BaseTest
    {
       /* [Test]
        public void Skorlamalar()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateGlaskow();
            dashboardPage.calculateApache();
            dashboardPage.calculateSaps();
            dashboardPage.calculateSofa();
            dashboardPage.calculateEgrf();
            dashboardPage.basamakSec();
            dashboardPage.BilincSec();
            dashboardPage.BoyKiloAyarla();
        }*/

        [Test]
        public void CalculateGlaskow()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateGlaskow();
        }
        [Test]
        public void CalculateApache()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateApache();
        }
        [Test]
        public void CalculateSaps()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateSaps();
        }
        [Test]
        public void CalculateSofa()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateSofa();
        }
        [Test]
        public void CalculateEgrf()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.calculateEgrf();
        }
        [Test]
        public void BasamakBilincBoyKiloIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.basamakSec();
            dashboardPage.BilincSec();
            dashboardPage.BoyKiloAyarla();
        }

        [Test]
        public void InvalizEkle()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var dashboardPage = homePage.dashboardSayfasinaGit();
            dashboardPage.InvazivEkleSil();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
