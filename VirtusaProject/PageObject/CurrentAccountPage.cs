using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtusaProject.Utilities;

namespace VirtusaProject.PageObject
{
    public class CurrentAccountPage
    {
        IWebElement AccountFees => Hook.Driver.FindElement(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div[3]/div/div/div/div/div[2]/p/span/strong"));


        public bool CurrentAccountsDisplayed(String accountsProducts)
        {
            try
            {
                WaitforElement.Wait();
                ExecuteScript.JavascriptExecutorCoordinate();
                WaitforElement.Wait();
                IList<IWebElement> accounts = Hook.Driver.FindElements(By.XPath("//*[@id='main']/div[4]/div/div/div/div/div[2]/div/div/div/div/div/div/div/a/span"));
                int i = 0;
                foreach (IWebElement element in accounts)
                {

                    if (element.Text.Contains(accountsProducts))
                    {
                        bool displayedObject = element.Displayed;
                        return true;
                    }

                }
                i++;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }


        public string PlatinumFees(string fees)
        {
            ExecuteScript.JavascriptCoordinate();
            WaitforElement.Wait();
            fees = AccountFees.Text;
            return fees;
        }
    }
}
