using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Samurai
    {
        public List<IItem> Items { get; set; } 

        readonly IWeapon weapon;
        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
            Items = new List<IItem>();
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
