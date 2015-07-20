using Autofac;
using MyNgApp.Data;
using MyNgAPP.Mappers;
using MyNgApp.Service;

namespace MyNgAPP
{
    public static class DependencyConfigure
    {
      
        public static void Init(ContainerBuilder containerBuilder)
        {
            MapperConfiguration.Configure();
            Register(containerBuilder);
        }

        private static void Register(ContainerBuilder containerBuilder)
        {
            RepositoryDependency.Register(containerBuilder);
            ServiceDependency.Register(containerBuilder);
        }
    }
}