using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Samurai
    {
        public List<IItem> Items { get; private set; } 

        readonly IWeapon _weapon;

        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
            this.Items = new List<IItem>();
        }

        public void PickupItem(IItem item)
        {
            Items.Add(item);
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }
    }
}
