namespace MyWebSite
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Web.Http.Controllers;
    using System.Web.Http.Dispatcher;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.SessionState;

    using Microsoft.Practices.Unity;

    public class HttpControllerActivator : IHttpControllerActivator, IControllerFactory
    {
        private readonly IUnityContainer _container;

        public HttpControllerActivator(IUnityContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpControllerContext controllerContext, Type controllerType)
        {
            return (IHttpController)_container.Resolve(controllerType);
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return (IHttpController)_container.Resolve(controllerType);
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var controllerTypes = (from t in currentAssembly.GetTypes()
                                  where t.Name.Contains(controllerName + "Controller")
                                  select t).ToList();

            if (controllerTypes.Count > 0)
            {
                return _container.Resolve(controllerTypes.First()) as IController;
            }
            return null; 
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            controller = null;
        }
    }
}
