﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISamurai.Models;

namespace DIByHand
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior1 = new Samurai(new Shuriken());
            var warrior2 = new Samurai(new Sword());

            warrior1.Attack("the evildoers");
            warrior2.Attack("the evildoers");

            warrior1.PickupItem(new Ration());

            warrior2.SecondaryWeapon = new Shuriken();

            Console.ReadLine();
        }
    }
}
