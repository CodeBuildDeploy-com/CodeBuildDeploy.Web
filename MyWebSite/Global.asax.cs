using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyWebSite
{
    using System.Web.Http.Dispatcher;

    using Microsoft.Practices.Unity;

    using MyWebSite.DataAccess;
    using MyWebSite.Repositories;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = new UnityContainer();
            container.RegisterInstance<IBlogRepository>(new BlogRepository(new DAContext()));
            var controllerActivator = new HttpControllerActivator(container);
            container.RegisterInstance<IHttpControllerActivator>(controllerActivator);
            container.RegisterInstance<IControllerFactory>(controllerActivator);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(container);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), container.Resolve<IHttpControllerActivator>());
            ControllerBuilder.Current.SetControllerFactory(container.Resolve<IControllerFactory>());
        }
    }
}
