using System;
using System.Runtime.CompilerServices;
using FluentAutomation;
using GOOS_SampleTests.DataModelsForIntegrationTest;
using GOOS_SampleTests.PageObject;
using GOOS_SampleTests.Step;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GOOS_SampleTests
{
    [Binding]
    public class BudgetSteps : FluentTest
    {
        private BudgetCreatePage _budgetCreatePage;

        public BudgetSteps()
        {
            _budgetCreatePage = new BudgetCreatePage(this);
        }

        [Given(@"go to adding budget page")]
        public void GivenGoToAddingBudgetPage()
        {
            this._budgetCreatePage.Go();
        }

        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int amount, string yearMonth)
        {

            this._budgetCreatePage
                  .Amount(amount)
                  .Month(yearMonth)
                  .AddBudget();
        }

        [Then(@"it should display ""(.*)""")]
        public void ThenItShouldDisplayAddedSuccessfull(string message)
        {
            this._budgetCreatePage.ShouldDisplay(message);
        }


        [Given(@"Budget table existed budgets")]
        public void GivenBudgetTableExistedBudgets(Table table)
        {
            var budgets = table.CreateSet<Budget>();
            using (var dbcontext = new NorthwindEntitiesForTest())
            {
                dbcontext.Budgets.AddRange(budgets);
                dbcontext.SaveChanges();
            }
        }
    }
}
