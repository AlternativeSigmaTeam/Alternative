

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
            builder.RegisterType<AlternativeService>().As<IAlternativeService>();
            builder.RegisterType<TeacherService>().As<ITeacherService>();
            builder.RegisterType<SpecialtyService>().As<ISpecialtyService>();
            builder.RegisterType<CourseService>().As<ICourseService>();
        }
    }
}
