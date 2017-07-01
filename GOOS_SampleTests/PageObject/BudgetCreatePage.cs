using System;
using FluentAutomation;

namespace GOOS_SampleTests.PageObject
{
    internal class BudgetCreatePage : PageObject<BudgetCreatePage>
    {
        private BudgetCreatePage _budgetCreatePage;


        public BudgetCreatePage(FluentTest test)
            : base(test)
        {
        }

        public BudgetCreatePage Amount(object amount)
        {
            return this;
        }

        public BudgetCreatePage Month(string yearMonth)
        {
            return this;
        }

        public BudgetCreatePage AddBudget()
        {
            return this;
        }

        public BudgetCreatePage ShouldDisplay(object message)
        {
            throw new NotImplementedException();
        }
    }
}