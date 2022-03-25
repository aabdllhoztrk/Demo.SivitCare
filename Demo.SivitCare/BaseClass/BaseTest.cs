using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.Selenium.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void NavigatetoDemoSivitCare()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Window.Maximize();           
            driver.Url = "http://192.168.1.9:81/";
           // options.AddAdditionalCapability("resolution", "1024x1536", true);
            /*
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.body.style.zoom = '0.9'");
            */
        }
    }
}

