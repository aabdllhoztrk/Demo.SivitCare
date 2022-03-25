using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Demo.SivitCare.Selenium.PageObject;

namespace Demo.SivitCare.Selenium.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }


        
        public IWebElement btn_fullScreen => FindElementByXPath("//button[@class='mat-focus-indicator mat-icon-button mat-button-base ng-star-inserted']");
        public IWebElement txt_UserName => FindElementByXPath("//*[@id='mat-input-0']"); 
        public IWebElement txt_Password => FindElementByXPath("/html/body/app-root/app-login/form/div/mat-drawer-container/mat-drawer-content/div[1]/mat-form-field[2]/div/div[1]/div[4]/input");
        public IWebElement btn_Login => FindElementByXPath("//span[contains(text(),'Giriş')]");
        public IWebElement dropdownDil => FindElementByXPath("/html/body/app-root/app-login/form/div/mat-drawer-container/mat-drawer-content/div[1]/mat-form-field[4]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement selectTurkce => FindElementByXPath("//SPAN[@class='mat-option-text'][text()=' Türkçe ']");


        public HomePage LoginOlma()
        {
            btn_fullScreen.Click();
            txt_UserName.SendKeys("AO");
            txt_Password.SendKeys("Ao12.");
            dropdownDil.Click();
            selectTurkce.Click();
            btn_Login.Click();
            Thread.Sleep(3000);
            return new HomePage(Driver);
        }

    }
}
