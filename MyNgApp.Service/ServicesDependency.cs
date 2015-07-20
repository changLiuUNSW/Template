using Autofac;

namespace MyNgApp.Service
{
    public static class ServiceDependency
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<HolidayService>().As<IHolidayService>().InstancePerRequest();
        }
    }
}