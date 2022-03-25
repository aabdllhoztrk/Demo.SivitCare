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
   public class TC4_HemsireIslemleri:BaseTest
    {
       
        [Test]
        public void BasiYarasiIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.basiYarasiEkle();

        }
        [Test]
        public void İnvazivİslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.InvazivGirisimEkle();
            hemsireIslemleriPage.InvazivDuzenle();
            hemsireIslemleriPage.InvazivCikar();
            hemsireIslemleriPage.InvazivSil();
        }

        [Test]
        public void AgriTakibiİslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.AgriTakibiEkleSil();
        }
        [Test]
        public void HemsireDegerlendirmeIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.HemsireDegerlendirmeEkleDuzenleSil();
        }
        [Test]
        public void CiltTanimlamaIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.CiltTanimlama();
        }
        [Test]
        public void HastaIzalasyonIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.HastaIzalasyonu();
        }
         [Test]
         public void HastaBeslemeIslemeleri() 
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.HastaNutrisyon();
        }
        [Test]
        public void HareketKisitlamaIslemleri()
        {
            var login = new LoginPage(driver);
            var homePage = login.LoginOlma();
            var hemsireIslemleriPage = homePage.hemsireSayfasinaGit();
            hemsireIslemleriPage.HareketKisitlama();
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
