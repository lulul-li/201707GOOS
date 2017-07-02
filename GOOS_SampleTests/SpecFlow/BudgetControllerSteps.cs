using System;
using System.Linq;
using System.Web.Mvc;
using FluentAssertions;
using GOOS_Sample.Controllers;
using GOOS_Sample.Models.ViewModels;
using GOOS_SampleTests.DataModelsForIntegrationTest;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GOOS_SampleTests.SpecFlow
{
    [Binding]
    public class BudgetControllerSteps
    {
        private BudgetController _budgetController;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            this._budgetController = new BudgetController();
        }

        [When(@"add budget")]
        public void WhenAddBudget(Table table)
        {
            var model = table.CreateInstance<BudgetAddViewModel>();
            var result=_budgetController.Add(model);

            ScenarioContext.Current.Set<ActionResult>(result);
        }
        
        [Then(@"should have a message for adding successfully")]
        public void ThenShouldHaveAMessageForAddingSuccessfully()
        {
            var result = ScenarioContext.Current.Get<ActionResult>() as ViewResult;
            string msg = result.ViewBag.Message;
            msg.Should().Be(GetAddingSuccessfullyMessage());
        }

        private string GetAddingSuccessfullyMessage()
        {
            return "added successfully";
        }

        [Then(@"should exist a budget record in budget table")]
        public void ThenShouldExistABudgetRecordInBudgetTable(Table table)
        {
            using (var dbcontext = new NorthwindEntitiesTest())
            {
                var budget = dbcontext.Budgets
                    .FirstOrDefault();
                budget.Should().NotBeNull();
                table.CompareToInstance(budget);
            }
        }
    }
}
