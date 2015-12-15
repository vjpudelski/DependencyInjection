using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISamurai.Models;
using Ninject.Modules;

namespace DINinject.Models
{
    public class NinjaModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<IItem>().To<Ration>();
        }
    }
}
