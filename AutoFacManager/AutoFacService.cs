using System;
using Autofac;
using Autofac.Core;

namespace AutoFacManager
{
    public class AutoFacService
    {
        static IContainer container = null;

        public static ContainerBuilder builder = null;
        public static IComponentContext context = null;


        static AutoFacService()
        {
            if (builder == null)
            {
                builder = new ContainerBuilder();
            }
            builder.RegisterModule<InterfaceModule>();
            builder.RegisterModule(new InstanceModule());
        }


        public IComponentContext AutoFacContainer()
        {
            if (context == null)
            {
                context = builder.Build();
            }
            return container;
        }
    }

    public class InterfaceModule : IModule
    {
        public void Configure(IComponentRegistry componentRegistry)
        {
            throw new NotImplementedException();
        }
    }


    public class InstanceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }


}
