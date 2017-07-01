namespace GOOS_Sample.Models
{
    public class BudgetRepository : IRepository<Budget>
    {
        public void Save(Budget entity)
        {

            using (var dbcontext = new NorthwindEntities())
            {
                dbcontext.Budgets.Add(entity);
                dbcontext.SaveChanges();
            }
        }
    }
}