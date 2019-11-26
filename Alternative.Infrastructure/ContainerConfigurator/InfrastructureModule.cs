using Autofac;

namespace Alternative.Infrastructure.ContainerConfigurator
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<BllModule>();
            builder.RegisterModule<DALModule>();
        }
    }
}
