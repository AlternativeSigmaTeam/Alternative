using Alternative.DAL.Context;
using Autofac;

namespace Alternative.Infrastructure.ContainerConfigurator
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AlternativeContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}