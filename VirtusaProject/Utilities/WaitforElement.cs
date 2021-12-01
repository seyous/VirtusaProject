using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtusaProject.Utilities
{
    public static class WaitforElement
    {
        public static void Wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public static void ImplicitWaitforElement()
        {
            Hook.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

        }
    }
}
