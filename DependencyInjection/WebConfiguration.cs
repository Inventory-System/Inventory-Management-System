using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Galaxy.Base.Controller;
using Galaxy.Base.Domain.ServiceInterface;
using Galaxy.Base.Domain.ServiceInterfaces;
using Galaxy.Base.Service;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace DependencyInjection
{
    public static class WebConfiguration
    {
        private static IWindsorContainer container;
      //  public static IProductService RegisterProductService()
        public static IMeasurementService RegisterProductService()
        {
            container = new WindsorContainer();
            container.Install(FromAssembly.Containing<DependencyInstaller>());


            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
            var dependencyResolver = new WindsorDependencyResolver(container);
          //  var productService = container.Resolve<IProductService>();
            var mService = container.Resolve<IMeasurementService>();
            return mService;
            //var measurmentService = container.Resolve<IMeasurmentService>();
            //return measurmentService;
            //config.DependencyResolver = dependencyResolver;
            //config.MapHttpAttributeRoutes();
            //config.Routes.MapHttpRoute(name: "ActionApi", routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional });

            //config.Filters.Add(new AuthorizeAttribute());
            //if (!Debugger.IsAttached) config.Filters.Add(new ValidateAntiForgeryTokenAttribute(IdentityConfig.GetIdentityOption()));

            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/octet-stream"));
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            ////configure app to return camelCase JSON
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
            //config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new IsoDateTimeConverter
            //{
            //    DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"
            //});


        }

        //public static IMeasurmentService RegisterMeasurementService()
        //{
        //    container = new WindsorContainer();
        //    container.Install(FromAssembly.Containing<DependencyInstaller>());


        //    container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
        //    var dependencyResolver = new WindsorDependencyResolver(container);
        //    var measurementService = container.Resolve<IMeasurmentService>();
        //    return measurementService;
        //}

    }
}
