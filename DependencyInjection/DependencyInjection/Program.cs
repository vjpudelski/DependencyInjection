using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");

            warrior1.Items.Add(new Ration());
            warrior1.Items[0].Use();

            Console.ReadLine();
        }
    }
}
