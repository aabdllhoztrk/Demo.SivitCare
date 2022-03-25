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
   public class VitalBulgularPage : BasePage
    {
        public VitalBulgularPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement btn_VitalEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[4]/div/app-vital/div[1]/div/div/button[1]");
        public IWebElement txt_SpO2 => FindElementByXPath("//input[@data-placeholder='SpO2 0 ~ 100']");
        public IWebElement txt_KalpAtimi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[2]/div/div[1]/div[1]/input");
        public IWebElement txt_VucutIsisi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[3]/div/div[1]/div[1]/input");
        public IWebElement txt_Resp => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[4]/div/div[1]/div[1]/input");
        public IWebElement txt_Bpsys => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[5]/div/div[1]/div[1]/input");
        public IWebElement txt_Bpdias => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[6]/div/div[1]/div[1]/input");
        public IWebElement txt_cvpMean => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[2]/mat-form-field[7]/div/div[1]/div[1]/input");
        public IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");

        /// <summary>
        /// Validate Vital Bulgular
        /// </summary>
        public IWebElement validateSpo2 => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='59 ']");
        public IWebElement validateKalpAtimi => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='449 ']");
        public IWebElement validateVucutIsisi => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='37 ']");
        public IWebElement validateResp => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='71 ']");
        public IWebElement validateBpsys => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='263 ']");
        public IWebElement validateBpdias => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='162 ']");
        public IWebElement validatecvpMean => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='219 ']");


        /// <summary>
        /// Vantilator Sil/Doğrula
        /// </summary>        
        public IWebElement spO2fromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' SpO2']");
        public IWebElement kalpAtimifromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Kalp Atımı']");
        public IWebElement vucutIsisifromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' Vücut Isısı']");
        public IWebElement respfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' RESP']");
        public IWebElement bpSysfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' BP SYS']");
        public IWebElement bpDiasfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' BP DIAS']");
        public IWebElement cvpMeanfromTable => FindElementByXPath("//TD[@role='gridcell'][text()=' CVP MEAN']");



        public IWebElement deneme => FindElementByXPath("//TD[@role='gridcell'][text()=' 59']");


        


        public void VitalEkle() 
        {            
            btn_VitalEkle.Click();
            sendKeys(txt_SpO2, "59");
            sendKeys(txt_KalpAtimi, "449");
            sendKeys(txt_VucutIsisi, "37");
            sendKeys(txt_Resp, "71");
            sendKeys(txt_Bpsys, "263");
            sendKeys(txt_Bpdias, "162");
            sendKeys(txt_cvpMean, "219");
            
            btn_Kaydet.Click();
        }
        public void ValidateVitalBulgular() 
        {
            ValidateElementExist(validateSpo2, "59");
            ValidateElementExist(validateKalpAtimi, "449");
            ValidateElementExist(validateVucutIsisi, "37");
            ValidateElementExist(validateResp, "71");
            ValidateElementExist(validateBpsys, "263");
            ValidateElementExist(validateBpdias, "162");
            ValidateElementExist(validatecvpMean, "219");

        }
        public void VitalSil() 
        {
            ScrollDownforVitalPage();
            spO2fromTable.Click();
            ValidateElementExisting(deneme);
            Sil();
            ValidateElementNotExist("Spo2", "//span[contains(text(),'59')]");
            ValidateElementNotExist("Spo2", "//TD[@role='gridcell'][text()=' 59']");
            kalpAtimifromTable.Click();
            Sil();
            ValidateElementNotExist("Kalp Atimi", "//span[contains(text(),'449')]");
            vucutIsisifromTable.Click();
            Sil();
            ValidateElementNotExist("Vucut İsisi", "//span[text()='37 ']");
            respfromTable.Click();
            Sil();
            ValidateElementNotExist("RESP", "//span[contains(text(),'71')]");
            bpSysfromTable.Click();
            Sil();
            ValidateElementNotExist("BP Sys", "//span[contains(text(),'263')]");
            bpDiasfromTable.Click();
            Sil();
            ValidateElementNotExist("BP Dias", "//span[contains(text(),'162')]");
            ScrollDown();
            cvpMeanfromTable.Click();
            Sil();
            ValidateElementNotExist("Cvp Mean", "//span[contains(text(),'219')]");            
        }
        
    }
}
