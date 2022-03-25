using Demo.SivitCare.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.Selenium.PageObject
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement btn_GuvenliCikis => FindElementByXPath("/html/body/app-root/main-app/div/karmed-headerbar/karmed-statusbar/mat-toolbar/button[5]");
        public IWebElement patient => FindElementByXPath("//span[contains(text(),'Ana')]");
        public IWebElement ServisDegistir => FindElementByXPath("/html/body/app-root/main-app/div/karmed-headerbar/karmed-statusbar/mat-toolbar/button[4]");
        public IWebElement btn_CerrahiYogunBakim => FindElementByXPath("//SPAN[text()='Cerrahi Yoğun Bakım Servisi']");
        public IWebElement tabVitalBulgular=> FindElementByXPath("//div[contains(text(),'Vital Bulgular')]");
        public IWebElement tabHemsireIslemleri => FindElementByXPath("//div[contains(text(),'Hemşire İşlemleri')]");
        public IWebElement tabHizmetIsleme => FindElementByXPath("//div[contains(text(),'Hizmet İşleme')]");
        public IWebElement btn_menuBar => FindElementByXPath("//button[@class='mat-focus-indicator mat-menu-trigger mat-icon-button mat-button-base']");
        public IWebElement secventilator => FindElementByXPath("//SPAN[text()='VENTİLATÖR']");
        public IWebElement secSiviGiren => FindElementByXPath("//SPAN[text()='SIVI GİREN']");
        public IWebElement secSiviCikan => FindElementByXPath("//SPAN[text()='SIVI ÇIKAN']");
        public IWebElement secKanGazlari  => FindElementByXPath("//SPAN[text()='KAN GAZLARI']");
        public IWebElement secLab => FindElementByXPath("//SPAN[text()='LABORATUVAR']");

        public void Cikis()
        {           
            btn_GuvenliCikis.Click();
            Thread.Sleep(3000);
        }

        public DashboardPage dashboardSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(2000);
            patient.Click();
            Thread.Sleep(3000);
            return new DashboardPage(Driver);
        }

        public VitalBulgularPage vitalBulgularSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(500);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            return new VitalBulgularPage(Driver);
        }

        public HemsireIslemleriPage hemsireSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabHemsireIslemleri.Click();
            return new HemsireIslemleriPage(Driver);
        }

        public HizmetIslemePage hizmetIslemeSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(500);
            patient.Click();
            Thread.Sleep(3000);
            tabHizmetIsleme.Click();
            return new HizmetIslemePage(Driver);
        }
        public VentilatorPage ventilatorSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secventilator.Click();
            return new VentilatorPage(Driver);
        }

        public SiviGirenPage SiviGirenSayfasinaGit()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secSiviGiren.Click();
            return new SiviGirenPage(Driver);
        }
        public SiviCikanPage SiviCikanSayfasinaGit()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secSiviCikan.Click();
            return new SiviCikanPage(Driver);
        }
        public KanGazlariPage KanGazlariSayfasinaGit()
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secKanGazlari.Click();
            return new KanGazlariPage(Driver);
        }
        public LaboratuvarVitalPage VitalAltindaLabSayfasinaGit() 
        {
            ServisDegistir.Click();
            btn_CerrahiYogunBakim.Click();
            Thread.Sleep(1000);
            patient.Click();
            Thread.Sleep(3000);
            tabVitalBulgular.Click();
            btn_menuBar.Click();
            Thread.Sleep(1000);
            secLab.Click();
            return new LaboratuvarVitalPage(Driver);
        }
    }
}
