using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace MyNgAPP.App_Start
{
    public class Bootstrapper
    {
        public static void Configure()
        {
            ConfigureAutofacContainer();
        }

        public static void ConfigureAutofacContainer()
        {
            var webApiContainerBuilder = new ContainerBuilder();
            ConfigureWebApiContainer(webApiContainerBuilder);
        }

        public static void ConfigureWebApiContainer(ContainerBuilder containerBuilder)
        {

            DependencyConfigure.Init(containerBuilder);
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            IContainer container = containerBuilder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}