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
    public class SiviGirenPage : BasePage
    {
        public SiviGirenPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Giren ve Oral verilen Sıvı Ekle/Doğrula
        /// </summary>
        public IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        public IWebElement dropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[3]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement secGirenSivi => FindElementByXPath("//span[contains(text(),'Giren Sıvı')]");
        public IWebElement secOralVerilenSivi => FindElementByXPath("//span[contains(text(),'Oral Verilen Sıvı')]");
        public IWebElement txt_DegerBulgu => FindElementByXPath("//input[@data-placeholder='Değer']");
        public IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        public IWebElement validateGirenSivi => FindElementByXPath("//TD[@role='gridcell'][text()=' 15']");
        public IWebElement validateOralSivi => FindElementByXPath("//TD[@role='gridcell'][text()=' 16']");

        /// <summary>
        /// Sol Taraf Vitaller Tablosu
        /// </summary>
        public IWebElement girenSiviFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Giren Sıvı']");
        public IWebElement oralVerilenSiviFromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Oral Verilen Sıvı']");
        public IWebElement validateGirenSiviFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='15 ']");
        public IWebElement validateOralSiviFromTable => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='16 ']");
        public void GirenSiviEkleSil() 
        {
            
            btn_Ekle.Click();
            dropDown.Click();
            secGirenSivi.Click();
            sendKeys(txt_DegerBulgu,"15");
            btn_Kaydet.Click();
            girenSiviFromTable.Click();
            ValidateElementExist(validateGirenSiviFromTable,"15");
            ValidateElementExist(validateGirenSivi, "15");
            Sil();
            ValidateElementNotExist("Giren Sivi from table", "//SPAN[@class='ng-star-inserted'][text()='15 ']");
            ValidateElementNotExist("Giren Sivi", "//TD[@role='gridcell'][text()=' 15']");
        }
        public void OralVerilenSiviEkleSil()
        {
            btn_Ekle.Click();
            dropDown.Click();
            secOralVerilenSivi.Click();
            sendKeys(txt_DegerBulgu, "16");
            btn_Kaydet.Click();
            oralVerilenSiviFromTable.Click();
            ValidateElementExist(validateOralSiviFromTable, "16");
            ValidateElementExist(validateOralSivi, "16");
            Sil();
            ValidateElementNotExist("Giren Oral Sivi from table", "//SPAN[@class='ng-star-inserted'][text()='16 ']");
            ValidateElementNotExist("Giren Oral Sivi", "//TD[@role='gridcell'][text()=' 16']");
        }

    }
}
