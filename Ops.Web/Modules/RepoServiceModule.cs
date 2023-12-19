using Autofac;
using Ops.Core.Repositories;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using Ops.Repository;
using Ops.Repository.Repositories;
using Ops.Repository.UnitOfWorks;
using Ops.Service.Mapping;
using Ops.Service.Services;
using System.Reflection;

namespace Ops.Web.Modules
{
    public class RepoServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<,,>)).As(typeof(IService<,,>)).InstancePerLifetimeScope();


            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
