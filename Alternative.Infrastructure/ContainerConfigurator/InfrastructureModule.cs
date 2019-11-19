using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Alternative.Infrastructure.ContainerConfigurator
{
    class InfrastructureModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<BllModule>();
            builder.RegisterModule<DALModule>();
        }
    }
}
