using Alternative.DAL;
using Alternative.DAL.Context;
using Alternative.DAL.Interfaces;
using Alternative.DAL.Repository;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using Autofac;

namespace Alternative.Infrastructure.ContainerConfigurator
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<AlternativeContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(SqlRepository<>)).AsSelf().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(SqlRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<SqlRepository<User>>().As<IRepository<User>>().InstancePerLifetimeScope();
            builder.RegisterType<RepositoryFactory>().As<IRepositoryFactory>().InstancePerDependency();
        }
    }
}