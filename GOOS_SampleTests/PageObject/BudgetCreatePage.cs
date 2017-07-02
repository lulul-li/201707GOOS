using FluentAutomation;

namespace GOOS_SampleTests.PageObject
{
    internal class BudgetCreatePage : PageObject<BudgetCreatePage>
    {
        public BudgetCreatePage(FluentTest test):base(test)
        {
            this.Url = string.Format("{0}/budget/add", PageContext.Domain);
        }

        public BudgetCreatePage Amount(int amount)
        {
            I.Enter(amount.ToString()).In("#amount");
            return this;
        }

        public BudgetCreatePage Month(string yearDate)
        {
            I.Enter(yearDate).In("#month");
            return this;
        }

        public void AddBudget()
        {
            I.Click("input[type=\"submit\"]");
        }

        public void ShowDisplayMsg(string msg)
        {
            I.Assert.Text(msg).In("#message");
        }
    }
}