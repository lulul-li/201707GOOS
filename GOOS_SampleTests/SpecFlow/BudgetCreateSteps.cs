using System;
using FluentAutomation;
using GOOS_SampleTests.PageObject;
using TechTalk.SpecFlow;

namespace GOOS_SampleTests
{
    [Binding]
    public class BudgetCreateSteps : FluentTest
    {
        private BudgetCreatePage _budgetCreatePage;

        public BudgetCreateSteps()
        {
            _budgetCreatePage = new BudgetCreatePage(this);
        }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }

        [Given(@"go to adding budget")]
        public void GivenGoToAddingBudget()
        {
            _budgetCreatePage.Go();
        }

        [When(@"I add buget (.*) for  ""(.*)""")]
        public void WhenIAddBugetFor(int amount, string yearDate)
        {
            _budgetCreatePage.Amount(amount).Month(yearDate).AddBudget();
        }

        [Then(@"it should display msg ""(.*)""")]
        public void ThenItShouldDisplayMsg(string msg)
        {
            _budgetCreatePage.ShowDisplayMsg(msg);
        }
    }
}
