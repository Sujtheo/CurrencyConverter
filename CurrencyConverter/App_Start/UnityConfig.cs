using CurrencyConverter.Business;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace CurrencyConverter
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType(typeof(ICurrencyData), typeof(CurrencyData));

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}