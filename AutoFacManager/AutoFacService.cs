using System;
using Autofac;

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
}
