﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Ration : IItem
    {
        public void Use()
        {
            Console.WriteLine("Eating a ration");
        }
    }
}
