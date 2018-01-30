using Autofac;
using Autofac.Core;
using System;

namespace AutoFacServer
{
    public class AutoFacService
    {
        static IContainer container = null;
        public static ContainerBuilder builder = null;


        static AutoFacService()
        {
            if (builder == null)
            {
                builder = new ContainerBuilder();
            }
            //builder.RegisterModule<InterfaceModule>();
            builder.RegisterModule(new InstanceModule());
        }


        public static IComponentContext AutoFacContainer()
        {
            if (container == null)
            {
                container = builder.Build();
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
            builder.RegisterType<BaseOne>().Named<BaseInterface>("BaseInterface");
            builder.RegisterType<BaseTwo>().Named<BaseInterface>("BaseInterface");
            builder.RegisterType<BaseThree>().Named<BaseInterface>("BaseInterface");
            base.Load(builder);
        }
    }


    public interface BaseInterface
    {
        void Load();
    }

    public class BaseOne : BaseInterface
    {
        public void Load()
        {
            Console.WriteLine("BaseoOne");
        }
    }


    public class BaseTwo : BaseInterface
    {
        public void Load()
        {
            Console.WriteLine("BaseTwo");
        }
    }


    public class BaseThree : BaseInterface
    {
        public void Load()
        {
            Console.WriteLine("BaseThree");
        }
    }
}
