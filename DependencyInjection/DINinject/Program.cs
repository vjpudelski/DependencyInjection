using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DINinject.Models;
using DISamurai.Models;
using Ninject;

namespace DINinject
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Bind<IWeapon>().To<Sword>();
            var samurai = kernel.Get<Samurai>();

            samurai.Attack("the evildoers");

            kernel.Bind<IItem>().To<Ration>();
            var samurai2 = kernel.Get<Samurai>();

            StandardKernel kernel2 = new StandardKernel();
            kernel2.Bind<IWeapon>().To<Shuriken>();
            kernel2.Bind<IItem>().To<Ration>();
            var ninja = kernel2.Get<Ninja>();

            StandardKernel kernel3 = new StandardKernel();
            kernel3.Bind<IWeapon>().To<Shuriken>();
            kernel3.Bind<IItem>().To<Ration>();
            kernel3.Bind<IItem>().To<Ration>();
            var ninja2 = kernel3.Get<Ninja>();

            StandardKernel kernel4 = new StandardKernel(new NinjaModule());
            var ninja3 = kernel4.Get<Ninja>();


            Console.ReadLine();
        }
    }
}
