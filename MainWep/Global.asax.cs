using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using MainWep.Domains;
using MainWep.Domains.StudentDomain.Infrastructure.Abstract;
using MainWep.Domains.StudentDomain.Infrastructure.Concrete;

namespace MainWep
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterAutofac();
        }
        void RegisterAutofac()
        {
            // configure autofac

            var builder = new ContainerBuilder();

            // regist all controller automaticly
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterControllers(typeof(MainWep.Controllers.HomeController).Assembly);


            //current Assembly
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().PropertiesAutowired().AsImplementedInterfaces();
            builder.RegisterType<EFStudentRepository>().As<IStudentRepository>();
            // regist all filters automatically
            builder.RegisterFilterProvider();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
