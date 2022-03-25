using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base (driver)
        {

        }       
        /// <summary>
        /// Apache Skorlama
        /// </summary>
        public IWebElement btn_Apache => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[3]/app-score-card/div/div[1]/div[2]/button");
        public IWebElement txt_Yas => FindElementByXPath("//input[@formcontrolname='Age']");
        public IWebElement txt_Vucutİsisi => FindElementByXPath("//input[@formcontrolname='Temp']");
        public IWebElement txt_OrtKanBasinci => FindElementByXPath("//input[@formcontrolname='MeanArterialPressure']");
        public IWebElement txt_OrtalamSolunumHizi => FindElementByXPath("//input[@formcontrolname='RespiratoryRate']");
        public IWebElement txt_Serum => FindElementByXPath("//input[@formcontrolname='SerumHCO3']");
        public IWebElement txt_Sodyum => FindElementByXPath("//input[@formcontrolname='Sodium']");
        public IWebElement txt_Ph => FindElementByXPath("//input[@formcontrolname='ArterialPh']");
        public IWebElement txt_Potasyum => FindElementByXPath("//input[@formcontrolname='Potassium']");
        public IWebElement txt_KalpHizi => FindElementByXPath("//input[@formcontrolname='HeartRate']");
        public IWebElement txt_Kreatinin => FindElementByXPath("//input[@formcontrolname='Creatinine']");
        public IWebElement txt_Hematokrit => FindElementByXPath("//input[@formcontrolname='Hematocrit']");
        public IWebElement txt_Glaskow => FindElementByXPath("//input[@formcontrolname='GlasgowComaScale']");
        public IWebElement txt_BeyazKan => FindElementByXPath("//input[@formcontrolname='Wbc']");
        public IWebElement txt_Fio2 => FindElementByXPath("//input[@formcontrolname='Fio2']");
        public IWebElement txt_PaO2 => FindElementByXPath("//input[@formcontrolname='O2']");
        public IWebElement btn_ApacheHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        public IWebElement btn_ApacheKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        public IWebElement validateApacheSkor => FindElementByXPath("//li[contains(text(),'Apache Skor:')]");
        public IWebElement validateApacheBeklenenOlum => FindElementByXPath("//li[contains(text(),'Beklenen Ölüm:')]");
        public IWebElement validateApacheSkoronDeshboard => FindElementByXPath("//div[text()='16']");
        /// <summary>
        /// Saps Skorlama
        /// </summary>
        /// 
        public IWebElement btn_SapsCinsiyet => FindElementByXPath("//span[contains(text(),'Erkek')]");
        public IWebElement btn_Saps => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[4]/app-score-card/div/div[1]/div[2]/button");
        public IWebElement txt_SapsYas => FindElementByXPath("//input[@formcontrolname='Age']");
        public IWebElement txt_SapsKalpHizi => FindElementByXPath("//input[@formcontrolname='HeartRate']");
        public IWebElement txt_Sistolik => FindElementByXPath("//input[@formcontrolname='SystolicBloodPressure']");
        public IWebElement txt_VucutIsisi => FindElementByXPath("//input[@formcontrolname='Temperature']");
        public IWebElement txt_SapsFio2 => FindElementByXPath("//input[@formcontrolname='Fio2']");
        public IWebElement txt_SapsPao2 => FindElementByXPath("//input[@formcontrolname='PaO2']");
        public IWebElement txt_GlaskowKoma => FindElementByXPath("//input[@formcontrolname='GlasgowComaScale']");
        public IWebElement txt_IdrarCikisi => FindElementByXPath("//input[@formcontrolname='UrineOutput']");
        public IWebElement txt_SapsSodyum => FindElementByXPath("//input[@formcontrolname='Sodium']");
        public IWebElement txt_SapsPotasyum => FindElementByXPath("//input[@formcontrolname='Potassium']");
        public IWebElement txt_Billrubin => FindElementByXPath("//input[@formcontrolname='Bilirubin']");
        public IWebElement txt_Wbc => FindElementByXPath("//input[@formcontrolname='WBC']");
        public IWebElement txt_Hco3 => FindElementByXPath("//input[@formcontrolname='HCO3']");
        public IWebElement txt_Ure => FindElementByXPath("//input[@formcontrolname='Urea']");
        public IWebElement yattigiBolum => FindElementByXPath("//span[contains(text(),'Acil Servis')]");
        public IWebElement klinikKatagori => FindElementByXPath("//span[contains(text(),'Dahili Hasta')]");
        public IWebElement yatisSekli => FindElementByXPath("//span[contains(text(),'Plansız')]");
        public IWebElement ventilatorTuru => FindElementByXPath("//span[contains(text(),'MV')]");
        public IWebElement zehirlenme => FindElementByXPath("//span[contains(text(),'Var')]");
        public IWebElement btn_SapsHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        public IWebElement btn_SapsKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        public IWebElement validateSapsSkor => FindElementByXPath("//li[contains(text(),'Saps Skor: 102')]");
        public IWebElement validateSapsBeklenenOlum => FindElementByXPath("//li[contains(text(),'Beklenen Ölüm: 74.7')]");
        public IWebElement validateSapsSkoronDashboard => FindElementByXPath("//div[text()='102']");
        /// <summary>
        /// Sofa skorlama
        /// </summary> 
        public IWebElement btn_Sofa => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[5]/app-score-card/div/div[1]/div[2]/button");
        public IWebElement txt_SofaPao2 => FindElementByXPath("//input[@formcontrolname='pao2']");                                                         
        public IWebElement txt_Fio=> FindElementByXPath("//input[@formcontrolname='fio2']");
        public IWebElement txt_Platelest => FindElementByXPath("//input[@formcontrolname='platelets']");
        public IWebElement txt_Billirubin => FindElementByXPath("//input[@formcontrolname='bilirubin']");
        public IWebElement txt_OrtArterBasinci => FindElementByXPath("//input[@formcontrolname='meanArterialPressure']");
        public IWebElement txt_SofaIdrarCikisi => FindElementByXPath("//input[@formcontrolname='urineOutput']");
        public IWebElement txt_GloskowKoma => FindElementByXPath("//input[@formcontrolname='glasgowComaScale']");
        public IWebElement txt_SofaKreatinin => FindElementByXPath("//input[@formcontrolname='creatinine']");
        public IWebElement vantilatorTuru => FindElementByXPath("//span[contains(text(),'MV')]");
        public IWebElement btn_SofaHesapla=> FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        public IWebElement btn_SofaKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        public IWebElement validatesofaSkor => FindElementByXPath("//li[contains(text(),'Sofa Skor:')]");
        public IWebElement validatebeklenenOlum => FindElementByXPath("//li[contains(text(),'Beklenen Ölüm:')]");
        public IWebElement validatesofaSkoronDashboard => FindElementByXPath("//div[text()='3']");

        /// <summary>
        /// Egrf Skorlama
        /// </summary>
        public IWebElement btn_Egrf => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[6]/app-score-card/div/div[1]/div[2]/button");
        public IWebElement txt_EgrfYas => FindElementByXPath("//input[@data-placeholder='Yaş']");
        public IWebElement txt_Creatinine => FindElementByXPath("//input[@data-placeholder='Creatinine']");
        public IWebElement btn_EgrfHesapla => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-primary']");
        public IWebElement btn_EgrfKaydet => FindElementByXPath("//button[@class='mat-focus-indicator mat-tooltip-trigger calculate-button mat-fab mat-button-base mat-accent ng-star-inserted']");
        public IWebElement validateEgrfSkor => FindElementByXPath(".//td[.//text()[contains(., '1,13')]]");
        public IWebElement validateEgrfSkoronDeshboard => FindElementByXPath("//div[text()='1,13']");
        public IWebElement btn_Carsaf => FindElementByXPath("//div[text()='Çarşaf']");
        public IWebElement btn_Dashboard => FindElementByXPath("//div[text()='Dashboard']");

        /// <summary>
        /// Glaskow Skorlama
        /// </summary>
        public IWebElement btn_Glaskow => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[1]/div/div[2]/app-score-card/div/div[1]/div[2]/button");     
        public IWebElement spontanAcik => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[1]/mat-radio-group/mat-radio-button[1]/label/span[1]");
        public IWebElement oryante => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[2]/mat-radio-group/mat-radio-button[1]/label/span[1]");
        public IWebElement cevapYok => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-glaskow-dialog/div[3]/mat-radio-group/mat-radio-button[6]/label/span[1]");
        public IWebElement btn_GlaskowKydet => FindElementByXPath("(//BUTTON[@mat-raised-button=''])[1]");
        public IWebElement validateGlaskowSkoronDeshboard => FindElementByXPath("//div[text()='10']");

        /// <summary>
        /// Basamak Sec
        /// </summary>
        public IWebElement btn_Basamak => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[3]/app-basamak/div[1]/div/button");
        public IWebElement selectBasamak => FindElementById("mat-radio-2");
        public IWebElement btn_BasamakKaydet => FindElementByXPath("(//BUTTON[@mat-raised-button=''])[1]");
        public IWebElement validateBasamak1 => FindElementByXPath("//span[contains(text(),'1. derece')]");

        /// <summary>
        /// Bilic Sec
        /// </summary>
        public IWebElement btn_Bilinc => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[1]/div/app-dashboard/div[3]/app-basamak/div[2]/div/button");
        public IWebElement selectStupor => FindElementByXPath("(//SPAN[@class='mat-radio-container'])[4]");
        public IWebElement btn_BilincKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateBilinc => FindElementByXPath("//span[contains(text(),'Stupor')]");

        /// <summary>
        /// Boy Kilo Değiştirme
        /// </summary>
        public IWebElement Kilo => FindElementByXPath("//span[contains(text(),'Kilo')]");
        public IWebElement Boy => FindElementByXPath("//span[contains(text(),'Boy 169')]");
        public IWebElement txt_Boy => FindElementByXPath("//input[@data-placeholder='170']");
        public IWebElement txt_Kilo => FindElementByXPath("//input[@data-placeholder='70']");
        public IWebElement btn_BoyKiloKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        

        /// <summary>
        /// İnvaziv Ekleme
        /// </summary>
        public IWebElement btn_InvalizEkle => FindElementByXPath("//button[@class='mat-focus-indicator icon-button-small mat-icon-button mat-button-base'][2]");
        public IWebElement txt_TupNo => FindElementByXPath("//input[@data-placeholder='Tüp No']");
        public IWebElement invaziGirisimDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-invasiv-dialog/div[3]/mat-form-field/div/div[1]/div/mat-select");
        public IWebElement txt_Endotrakeal => FindElementByXPath("//span[contains(text(),' Endotrakeal Tüp')]");
        public IWebElement btn_InvaziKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement onayYes => FindElementByXPath("//span[contains(text(),'Yes')]");
        public IWebElement validateBasamak3 => FindElementByXPath("//span[contains(text(),'3. derece')]");
        public IWebElement tabHemsireIslemleri => FindElementByXPath("//div[contains(text(),'Hemşire İşlemleri')]");
        public IWebElement btn_InvazivGirisimler => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer/div/div/a[2]");
        public IWebElement validateTarih => FindElementByXPath("//div[contains(text(),'Şu anda')]");
        public IWebElement validateTupNo => FindElementByXPath("//div[contains(text(),'1589')]");
        public IWebElement validateInvaziGiris => FindElementByXPath("//div[contains(text(),'Endotrakeal Tüp')]");
        public IWebElement btn_InvazivSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row/mat-cell[1]/div/button[2]");
        public IWebElement defaultyes => FindElementByXPath("//span[contains(text(),'Yes')]");

        public void InvazivEkleSil() 
        {
            btn_InvalizEkle.Click();
            sendKeys(txt_TupNo,"1589");
            invaziGirisimDropDown.Click();
            txt_Endotrakeal.Click();
            btn_InvaziKaydet.Click();
            onayYes.Click();
            ValidateElementExist(validateBasamak3, "3. derece");
            Thread.Sleep(3000);
            tabHemsireIslemleri.Click();
            Thread.Sleep(1000);
            btn_InvazivGirisimler.Click();
            ValidateElementExist(validateTarih, "Şu anda");
            ValidateElementExist(validateTupNo, "1589");
            ValidateElementExist(validateInvaziGiris, "Endotrakeal Tüp");
            btn_InvazivSil.Click();            
            defaultyes.Click();
            ValidateElementNotExist("Tarih", "//div[contains(text(),'Şu anda')]");
            ValidateElementNotExist("TüpNo", "//div[contains(text(),'1589')]");
        }
        

        public void calculateApache() 
        {
            
            Thread.Sleep(2000);
            btn_Apache.Click(); 
            sendKeys(txt_Yas, "45");
            sendKeys(txt_Vucutİsisi,"39");
            sendKeys(txt_OrtKanBasinci,"75"); 
            sendKeys(txt_OrtalamSolunumHizi,"20"); 
           //txt_Serum.SendKeys("25");
            sendKeys(txt_Sodyum,"137"); 
            sendKeys(txt_Ph,"7"); 
            sendKeys(txt_Potasyum,"4");
            sendKeys(txt_KalpHizi,"65"); 
            sendKeys(txt_Kreatinin,"0.74");
            sendKeys(txt_Hematokrit,"36");
            sendKeys(txt_Glaskow,"10");
            sendKeys(txt_BeyazKan,"4");
            sendKeys(txt_Fio2,"50");
            sendKeys(txt_PaO2,"150");
            btn_ApacheHesapla.Click();
            ValidateScoreResults(validateApacheSkor, "Apache Skor: 16");
            ValidateScoreResults(validateApacheBeklenenOlum, "Beklenen Ölüm: 23.5");
            btn_ApacheKaydet.Click();
            ValidateScoreResults(validateApacheSkoronDeshboard, "16");            
        }

        public void calculateSaps() 
        {
            Thread.Sleep(2000);
            btn_Saps.Click();
            btn_SapsCinsiyet.Click();
            sendKeys(txt_SapsYas, "38");
            sendKeys(txt_SapsKalpHizi,"38");
            sendKeys(txt_Sistolik,"65");
            sendKeys(txt_VucutIsisi,"38");
            sendKeys(txt_SapsFio2,"2");
            sendKeys(txt_SapsPao2, "100");
            sendKeys(txt_GlaskowKoma,"5");
            sendKeys(txt_IdrarCikisi,"0.4");
            sendKeys(txt_SapsSodyum,"147");
            sendKeys(txt_SapsPotasyum,"2");
            sendKeys(txt_Billrubin,"3");
            sendKeys(txt_Wbc,"888000");
            sendKeys(txt_Hco3,"13");
            sendKeys(txt_Ure,"9.77");
            yattigiBolum.Click();
            klinikKatagori.Click();
            yatisSekli.Click();
            ventilatorTuru.Click();
            zehirlenme.Click();
            btn_SapsHesapla.Click();
            ValidateScoreResults(validateSapsSkor, "Saps Skor: 102");
            ValidateScoreResults(validateSapsBeklenenOlum, "Beklenen Ölüm: 74.7");
            /* IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
             executor.ExecuteScript("document.body.style.zoom = '0.8'");*/
            btn_SapsKaydet.Click();
            Driver.Navigate().Refresh();
            ValidateScoreResults(validateSapsSkoronDashboard, "102");

        }
        public void calculateSofa()
        {
            Thread.Sleep(2000);
            btn_Sofa.Click();
            sendKeys(txt_SofaPao2, "90");
            sendKeys(txt_Fio, "20");
            sendKeys(txt_Platelest,"160");
            sendKeys(txt_Billirubin,"1.1");
            sendKeys(txt_OrtArterBasinci,"75");
            sendKeys(txt_SofaIdrarCikisi,"400");
            sendKeys(txt_GloskowKoma,"15");
            sendKeys(txt_SofaKreatinin,"1.1");
            vantilatorTuru.Click();
            btn_SofaHesapla.Click();
            ValidateScoreResults(validatesofaSkor, "Sofa Skor: 3");
            ValidateScoreResults(validatebeklenenOlum, "Beklenen Ölüm: < 10%");
            btn_SofaKaydet.Click();
            Driver.Navigate().Refresh();
            ValidateScoreResults(validatesofaSkoronDashboard, "3");
        }
        public void calculateEgrf() 
        {
            Thread.Sleep(1000);
            btn_Egrf.Click();
            sendKeys(txt_EgrfYas, "18");
            sendKeys(txt_Creatinine, "50");
            btn_EgrfHesapla.Click();
            Thread.Sleep(1000);
            btn_EgrfKaydet.Click();
            btn_Carsaf.Click();
            Thread.Sleep(1000);
            btn_Dashboard.Click();
            ValidateScoreResults(validateEgrfSkor,"1,13");
            ValidateScoreResults(validateEgrfSkoronDeshboard, "1,13");
        }
        public void calculateGlaskow() 
        {
            Thread.Sleep(1000);
            btn_Glaskow.Click();            
            spontanAcik.Click();
            oryante.Click();
            cevapYok.Click();
            btn_GlaskowKydet.Click();
            ValidateScoreResults(validateGlaskowSkoronDeshboard,"10");
        }
        public void basamakSec() 
        {
            Thread.Sleep(2000);
            btn_Basamak.Click();
            Thread.Sleep(2000);
            selectBasamak.Click();
            btn_BasamakKaydet.Click();
            ValidateElementExist(validateBasamak1,"1. derece");
            Thread.Sleep(4000);
        }
        public void BilincSec() 
        {
            Thread.Sleep(2000);
            btn_Bilinc.Click();
            Thread.Sleep(3000);
            selectStupor.Click();
            btn_BilincKaydet.Click();
            ValidateElementExist(validateBilinc, "Stupor");
            Thread.Sleep(4000);
        }     
        public void BoyKiloAyarla() 
        {
            Thread.Sleep(2000);
            Kilo.Click();
            sendKeys(txt_Kilo, "70");
            sendKeys(txt_Boy, "169");
            btn_BoyKiloKaydet.Click();
            ValidateElementExist(Boy, "Boy 169");
            ValidateElementExist(Kilo, "Kilo 70");
            
        }
    }
}
