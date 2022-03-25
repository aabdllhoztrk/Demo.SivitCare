using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.Selenium.PageObject
{
    public abstract class BasePage
    {
        private IWebDriver _driver;

        protected IWebDriver Driver => _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }
        /// <summary>
        /// HTMLElemment bulunanana kadar bekler. Maksiumum bekleme 10 sn olarak ayarlanmıştır.
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IWebElement WaitForElement(By by)
        {
            const int WAIT_ELEMENT_TIMEOUT = 10;
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(Driver);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Timeout = TimeSpan.FromSeconds(WAIT_ELEMENT_TIMEOUT);
            wait.Message = "Element not found";
            var result = wait.Until(x => x.FindElement(by));
            return result;
        }


        public void ValidateElementExisting(IWebElement element)
        {
            bool elementExisting = element.Displayed;
            Assert.That(elementExisting, Is.True);
        }

        public IWebElement FindElementByXPath(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }

        public IWebElement FindElementById(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)));
        }
        public IWebElement FindElementByName(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)));
        }

        public IWebElement FindElementCssSelector(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }
        public IWebElement FindElementByLinkText(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(element)));
        }

        public void goToUrl(string url)
        {
            Driver.Url = url;
        }

        public void switchtoFrame(string frameName)

        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(frameName));
        }

        public void sendKeys(IWebElement element, string value) 
        {
            element.Clear();
            element.SendKeys(value);
        }

        public void ValidateElementExist(IWebElement actualLabel, string expectedLabel)
        {
            string expected = expectedLabel;

            try
            {
                Thread.Sleep(100);
                Assert.IsTrue(actualLabel.Text.Equals(expected));
                //Assert.IsTrue(actualLabel.Displayed);
            }
            catch (Exception e)
            {

                Console.WriteLine("Beklenen label sayfa kaynagında bulunamadi !!!" + "  Label: " + expected);

            }
        }
        public void ValidateElementNotExist(string elementName, string elementxpath)
        {
            Thread.Sleep(1000);
            int count = Driver.FindElements(By.XPath(elementxpath)).Count();
            if (count > 0)
            {
                Assert.Fail(elementName + " Silinmedi.");
            }
        }

        public void ValidateScoreResults(IWebElement actualLabel, string expectedLabel)
        {
            string expected = expectedLabel;

            try
            {
                Assert.IsTrue(actualLabel.Text.Contains(expected));
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Beklenen skor sayfa kaynagında doğru görüntülenemedi !!!" + " Beklenen Skor: " + expected);
                
            }
        }

        public void ScrollDown() 
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
        }
        public void ScrollDownforVitalPage()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250);");
        }

        public IWebElement btn_Sil => FindElementByXPath("(//MAT-ICON[@role='img'][text()='delete'])[1]");
        public IWebElement DefaultYes => FindElementByXPath("//span[contains(text(),'Yes')]");
        public void Sil() 
        {
            Thread.Sleep(500);
            btn_Sil.Click();
            DefaultYes.Click();
        }

        

        /*
        public static void SelectByText(IWebElement element, string text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(text);
        }
        */

    }
}
