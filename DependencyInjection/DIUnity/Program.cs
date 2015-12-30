using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISamurai.Models;
using Microsoft.Practices.Unity;

namespace DIUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic constructor injection
            var container = new UnityContainer();
            container.RegisterType<IWeapon, Sword>();
            var samurai = container.Resolve<Samurai>();

            samurai.Attack("the evildoers");

            var container2 = new UnityContainer();
            container2.RegisterType<IWeapon, Shuriken>();
            InjectionProperty injectionProperty = new InjectionProperty("SecondaryWeapon", new Sword());
            container2.RegisterType<Samurai>(injectionProperty);
            // overriding the parameter of the constructor.
            var samurai2 = container2.Resolve<Samurai>(new ParameterOverride("weapon", new Sword()));

            Console.ReadLine();
        }
    }
}
