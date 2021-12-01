using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using VirtusaProject.PageObject;
using VirtusaProject.Utilities;

namespace VirtusaProject.StepDefinition
{
    [Binding]
    public class VerifyCurrentAccountSteps
    {
        private readonly HomePage _homePage;
        private readonly CurrentAccountPage _currentAccountPage;

        public VerifyCurrentAccountSteps(HomePage homePage, CurrentAccountPage currentAccountPage)
        {
            _homePage = homePage;
            _currentAccountPage = currentAccountPage;
        }

        [Given(@"I navigate to the URL")]
        public void GivenINavigateToTheURL()
        {
            Hook.Driver.Navigate().GoToUrl("https://www.lloydsbank.com/");
            Hook.Driver.Manage().Window.Maximize();
            WaitforElement.Wait();
        }

        [When(@"I click on Products and Services tab")]
        public void WhenIClickOnProductsAndServicesTab()
        {
            _homePage.ClickProductAndServices();
        }

        [When(@"I click on current account")]
        public void WhenIClickOnCurrentAccount()
        {
            _homePage.ClickCurrentAccount();
        }

        [Then(@"I am on the correct page")]
        public void ThenIAmOnTheCorrectPage()
        {
            String PageTitle = Hook.Driver.Url;
            WaitforElement.Wait();
            Assert.AreEqual(PageTitle, "https://www.lloydsbank.com/current-accounts.html");
        }


        [Then(@"there are ""(.*)"" products")]
        public void ThenThereAreProducts(string currentAccount)
        {
            WaitforElement.Wait();
            Assert.IsTrue(_currentAccountPage.CurrentAccountsDisplayed(currentAccount));

        }


        [Then(@"fees for Platinum account is ""(.*)""")]
        public void ThenFeesForPlatinumAccountIs(string platinum)
        {
            WaitforElement.Wait();
            Assert.AreEqual("£21 per month", _currentAccountPage.PlatinumFees(platinum));
        }


    }
}
