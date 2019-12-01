using Alternative.BLL.Interfaces;
using Alternative.BLL.Services;
using Autofac;

namespace Alternative.Infrastructure.ContainerConfigurator
{
    public class BllModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}
