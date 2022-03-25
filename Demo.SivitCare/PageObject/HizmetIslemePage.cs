using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public class HizmetIslemePage : BasePage
    {
        public HizmetIslemePage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement tabHizmetIsleme => FindElementByXPath("//div[contains(text(),'Hizmet İşleme')]");
        public IWebElement txt_Hizmet => FindElementByXPath("//input[@data-placeholder='Hizmet veya Paket Adı']");
        public IWebElement slctSpine=> FindElementByXPath("//span[contains(text(),'XR0041 - SPINE CERVICALTWO VIEWS')]");
        public IWebElement btn_hizmetEkle => FindElementByXPath("//button[@class='mat-focus-indicator mat-mini-fab mat-button-base mat-accent']");
        public IWebElement valitadeHizmetonPage => FindElementByXPath("//div[text()=' SPINE CERVICALTWO VIEWS ']");
        public IWebElement btn_Sil => FindElementByXPath("//button[@class='mat-focus-indicator mat-icon-button mat-button-base mat-warn'][1]");
        public IWebElement btn_DefaultYes => FindElementByXPath("//span[contains(text(),'Yes')]");

        public void HastayaHizmetIsle() 
        {
            sendKeys(txt_Hizmet, "spine");
            slctSpine.Click();
            btn_hizmetEkle.Click();
            Driver.Navigate().Refresh();
            tabHizmetIsleme.Click();
            ValidateElementExist(valitadeHizmetonPage, "SPINE CERVICALTWO VIEWS");
            btn_Sil.Click();
            btn_DefaultYes.Click();
            ValidateElementNotExist("SPINE CERVICALTWO VIEWS", "//div[text()=' SPINE CERVICALTWO VIEWS ']");
        }
    }
}
