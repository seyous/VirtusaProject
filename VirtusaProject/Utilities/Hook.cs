using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace VirtusaProject.Utilities
{

    [Binding]
    public sealed class Hook
    {
        public static ChromeDriver Driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            try
            {
                Driver = new ChromeDriver();
                Driver.ExecuteChromeCommand("Storage.clearCookies", new Dictionary<string, object>());
                WaitforElement.Wait();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Dispose();
        }
    }
}

