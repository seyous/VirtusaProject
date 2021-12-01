using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtusaProject.Utilities;

namespace VirtusaProject.PageObject
{
    public class HomePage
    {

        IWebElement ProductAndServicesMenu => Hook.Driver.FindElement(By.XPath("//a/span[text()='Products and services']"));
        IWebElement CurrentAccountSubmenu => Hook.Driver.FindElement(By.XPath("//*[@id='mainnav']/li[2]/div/ul/li[1]/a/span[1]"));
        IWebElement CookieConsent => Hook.Driver.FindElement(By.Id("Accept"));

        public void ClickProductAndServices()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)Hook.Driver;
            js.ExecuteScript("var clickEvent = document.createEvent('MouseEvents');clickEvent.initEvent('mouseover', true, true); arguments[0].dispatchEvent(clickEvent);", ProductAndServicesMenu);

        }

        public void ClickCurrentAccount()
        {
            Actions action = new Actions(Hook.Driver);
            action.MoveToElement(new WebDriverWait(Hook.Driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(CurrentAccountSubmenu))).Click().Perform();
        }

    }
}
