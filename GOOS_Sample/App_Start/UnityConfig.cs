using System.Web.Mvc;
using GOOS_Sample.Models;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace GOOS_Sample
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {

            var container = new UnityContainer();

            container.RegisterType<IRepository<Budget>, BudgetRepository>();
            container.RegisterType<IBudgetService, BudgetService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}