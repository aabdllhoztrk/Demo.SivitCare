using Demo.SivitCare.Selenium.BaseClass;
using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public class LaboratuvarVitalPage : BasePage
    {
        public LaboratuvarVitalPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        public IWebElement txt_Glukoz => FindElementByXPath("//input[@data-placeholder='Glukoz 0 ~ 900']");
        public IWebElement txt_WBC => FindElementByXPath("//input[@data-placeholder='WBC  ~ ']");
        public IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");
        public IWebElement GlukozfromLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
        public IWebElement WBCLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
        public IWebElement GlukozfromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 10.5']");
        public IWebElement WBCfromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 11.5']");


        public void LabDataEkleSil() 
        {
            btn_Ekle.Click();
            sendKeys(txt_Glukoz, "10,5");
            sendKeys(txt_WBC, "11,5");
            btn_Kaydet.Click();

            ///ValidateExist pH Glukoz, WBC From LeftSide
            ValidateElementExist(GlukozfromLeftSide, "10.5");
            ValidateElementExist(WBCLeftSide, "11.5");
            ///Validation for Ph
            GlukozfromLeftSide.Click();
            ValidateElementExist(GlukozfromRightSide, "10.5");
            Sil();
            ValidateElementNotExist("Glukoz From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
            ValidateElementNotExist(" From RightSide", "//TD[@role='gridcell'][text()=' 10.5']");
            ///Validation for WBC
            WBCLeftSide.Click();
            ValidateElementExist(WBCfromRightSide, "11.5");
            Sil();
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
            ValidateElementNotExist("Ph From RightSide", "//TD[@role='gridcell'][text()=' 11.5']");
        } 

    }
}
