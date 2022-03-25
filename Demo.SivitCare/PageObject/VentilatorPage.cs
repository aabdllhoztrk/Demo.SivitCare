using Demo.SivitCare.Selenium.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public class VentilatorPage : BasePage
    {
        public VentilatorPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Ventilator Ekle/Doğrula
        /// </summary>
        public IWebElement btn_VantilatorEkle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        public IWebElement txt_Peak => FindElementByXPath("//input[@data-placeholder='Peak  ~ ']");
        public IWebElement txt_Fio2 => FindElementByXPath("//input[@data-placeholder='Fio2  ~ ']");
        public IWebElement txt_VentMod => FindElementByXPath("//input[@data-placeholder='VentMod  ~ ']");
        public IWebElement txt_Rsb => FindElementByXPath("//input[@data-placeholder='RSB  ~ ']");
        public IWebElement btn_Kaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validatePeak => FindElementByXPath("//span[contains(text(),'150')]");
        public IWebElement validateFioz => FindElementByXPath("//span[contains(text(),'151')]");
        public IWebElement validateVentMod => FindElementByXPath("//span[contains(text(),'152')]");
        public IWebElement validateRsb => FindElementByXPath("//span[contains(text(),'153')]");

        /// <summary>
        /// Vantilator Sil/Doğrula
        /// </summary>
        public IWebElement peakfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Peak']");
        public IWebElement fio2fromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Fio2']");
        public IWebElement ventModfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' VentMod']");
        public IWebElement rsbfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' RSB']");

        public void VenlilatorEkle() 
        {            
            btn_VantilatorEkle.Click();
            sendKeys(txt_Peak,"150");
            sendKeys(txt_Fio2, "151");
            sendKeys(txt_VentMod, "152");
            sendKeys(txt_Rsb, "153");
            btn_Kaydet.Click();
            ValidateElementExist(validatePeak, "150");
            ValidateElementExist(validateFioz, "151");
            ValidateElementExist(validateVentMod, "152");
            ValidateElementExist(validateRsb, "153");
        }
        public void VentilatorSil() 
        {           
            Thread.Sleep(500);
            ScrollDown();
            peakfromTable.Click();
            Sil();
            ValidateElementNotExist("Peak from Vanlilator Page", "//span[contains(text(),'150')]");
            fio2fromTable.Click();
            Sil();
            ValidateElementNotExist("Fio2 from Vanlilator Page", "//span[contains(text(),'151')]");
            ventModfromTable.Click();
            Sil();
            ValidateElementNotExist("VentMod from Vanlilator Page", "//span[contains(text(),'152')]");
            rsbfromTable.Click();
            Sil();
            ValidateElementNotExist("Rsb from Vanlilator Page", "//span[contains(text(),'153')]");
        }        
    }
}
