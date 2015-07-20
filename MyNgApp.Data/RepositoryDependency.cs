using System.Data.Entity;
using Autofac;
using MyNgApp.Data.DbContexts;
using MyNgApp.Data.Infrastructure;

namespace MyNgApp.Data
{
    public static class RepositoryDependency
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ResourceManagerEntities>().As<DbContext>().InstancePerRequest();
            containerBuilder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerRequest();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
        }
    }
}
