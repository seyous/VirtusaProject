using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaProject.Utilities
{
    public static class ExecuteScript
    {
        public static void JavascriptExecutorCoordinate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hook.Driver;
            js.ExecuteScript("window.scrollBy(0, 1400)");
        }

        public static void JavascriptCoordinate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hook.Driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }
    }
}
