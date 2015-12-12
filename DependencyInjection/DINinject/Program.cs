using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.ReadLine();
        }
    }
}
