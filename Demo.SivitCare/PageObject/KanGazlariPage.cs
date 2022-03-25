using Demo.SivitCare.Selenium.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public class KanGazlariPage : BasePage
    {
        public KanGazlariPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement btn_Ekle => FindElementByXPath("//button[@class='mat-focus-indicator mat-fab mat-button-base mat-primary ng-star-inserted']");
        public IWebElement txt_Ph => FindElementByXPath("//input[@data-placeholder='pH 1 ~ 14']");
        public IWebElement txt_pCO2 => FindElementByXPath("//input[@data-placeholder='pCO2  ~ ']");
        public IWebElement txt_pO2 => FindElementByXPath("//input[@data-placeholder='pO2  ~ ']");
        public IWebElement btn_Kaydet => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-vital-dialog/div/div[5]/button[1]");

        public IWebElement PhfromLeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
        public IWebElement pCO2LeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
        public IWebElement pO2LeftSide => FindElementByXPath("//SPAN[@class='ng-star-inserted'][text()='12.5 ']");
        public IWebElement PhfromRightSide=> FindElementByXPath("//TD[@role='gridcell'][text()=' 10.5']");
        public IWebElement pCo2fromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 11.5']");
        public IWebElement pO2fromRightSide => FindElementByXPath("//TD[@role='gridcell'][text()=' 12.5']");

        


        public void KanGazlariEkleSil() 
        {
            btn_Ekle.Click();
            sendKeys(txt_Ph, "10,5");
            sendKeys(txt_pCO2,"11,5");
            sendKeys(txt_pO2, "12,5");
            btn_Kaydet.Click();
            ///ValidateExist pH, pCO2, pO2 From LeftSide
            ValidateElementExist(PhfromLeftSide,"10.5");
            ValidateElementExist(pCO2LeftSide, "11.5");
            ValidateElementExist(pO2LeftSide, "12.5");
            ///Validation for Ph
            PhfromLeftSide.Click();
            ValidateElementExist(PhfromRightSide, "10.5");
            Sil();
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='10.5 ']");
            ValidateElementNotExist("Ph From RightSide", "//TD[@role='gridcell'][text()=' 10.5']");
            ///Validation for pCO2
            pCO2LeftSide.Click();
            ValidateElementExist(pCo2fromRightSide, "11.5");
            Sil();
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='11.5 ']");
            ValidateElementNotExist("Ph From RightSide", "//TD[@role='gridcell'][text()=' 11.5']");
            ///Validation for pO2
            pO2LeftSide.Click();
            ValidateElementExist(pO2fromRightSide, "12.5");
            Sil();
            ValidateElementNotExist("Ph From LeftSide", "//SPAN[@class='ng-star-inserted'][text()='12.5 ']");
            ValidateElementNotExist("Ph From RightSide", "//TD[@role='gridcell'][text()=' 12.5']");

        }

    }
}
