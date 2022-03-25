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
    public class SiviCikanPage : BasePage
    {
        public SiviCikanPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// randomIdrarMiktari, kusma, defekasyon ekle/dogrula
        /// </summary>
        public IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        public IWebElement dropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[3]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement secIdrar => FindElementByXPath("//span[contains(text(),'İdrar')]");
        public IWebElement secKusma => FindElementByXPath("//span[contains(text(),'Kusma / NG')]");
        public IWebElement secDefekasyon => FindElementByXPath("//span[contains(text(),'Defekasyon')]");
        public IWebElement txt_DigerBulgu => FindElementByXPath("//input[@data-placeholder='Değer']");
        public IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        public IWebElement validateIdrar => FindElementByXPath("//TD[@role='gridcell'][text()=' 15']");
        public IWebElement validateKusma => FindElementByXPath("//TD[@role='gridcell'][text()=' 16']");
        public IWebElement validateDefekasyon => FindElementByXPath("//TD[@role='gridcell'][text()=' 17']");

        /// <summary>
        /// Sol Taraf Vitaller Tablosu
        /// </summary>
        public IWebElement idrarFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' İdrar']");
        public IWebElement kusmaFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Kusma / NG']");
        public IWebElement defekasyonFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Defekasyon']");
        public IWebElement validateIdrarFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='15 ']");
        public IWebElement validateKusmaFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='16 ']");
        public IWebElement validateDefekasyonFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='17 ']");

        public static int randomnum1 = RandomNumber.GetRandom();
        string randomIdrarMiktari = randomnum1.ToString();
        public void IdrarEkleSil()
        {
            
            btn_Ekle.Click();
            dropDown.Click();
            secIdrar.Click();
            sendKeys(txt_DigerBulgu, "15");
            btn_Kaydet.Click();
            idrarFromTable.Click();
            ValidateElementExist(validateIdrarFromTable, "15");
            ScrollDown();
            ValidateElementExist(validateIdrar, "15");
            Thread.Sleep(500);
            Sil();
            ValidateElementNotExist("Sivi Cikis Sayfasindan Idrar", "//SPAN[@class='ng-star-inserted'][text()='15']");
            ValidateElementNotExist("Idrar", "//TD[@role='gridcell'][text()='15']");

        }
        public void KusmaEkleSil()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secKusma.Click();
            sendKeys(txt_DigerBulgu, "16");
            btn_Kaydet.Click();
            kusmaFromTable.Click();
            ValidateElementExist(validateKusmaFromTable, "16");
            ScrollDown();
            ValidateElementExist(validateKusma, "16");
            
            Thread.Sleep(500);
            Sil();
            ValidateElementNotExist("Sivi Cikis Sayfasindan Kusma", "//SPAN[@class='ng-star-inserted'][text()='16 ']");
            ValidateElementNotExist("Kusma", "//TD[@role='gridcell'][text()=' 16']");
        }
        public void DefekasyonEkleSil()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secDefekasyon.Click();
            sendKeys(txt_DigerBulgu, "17");
            btn_Kaydet.Click();
            defekasyonFromTable.Click();
            ValidateElementExist(validateDefekasyonFromTable, "17");
            ValidateElementExist(validateDefekasyon, "17");
            Sil();
            ValidateElementNotExist("Sivi Cikis Sayfasindan Defekasyon", "//SPAN[@class='ng-star-inserted'][text()='17 ']");
            ValidateElementNotExist("Defekasyon", "//TD[@role='gridcell'][text()=' 17']");
        }
    }
}
