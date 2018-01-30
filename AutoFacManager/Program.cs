using AutoFacServer;
using System;
using Autofac;

namespace AutoFacManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutoFacService.AutoFacContainer();

            var rst = container.ResolveNamed<BaseInterface>("BaseInterface");
            var rst1 = container.ResolveNamed("BaseInterface", typeof(BaseInterface));


            Console.WriteLine("Hello World!");
        }
    }
}
