using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISamurai.Models
{
    public class Samurai
    {
        private readonly IWeapon _weapon;

        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }

        public IWeapon SecondaryWeapon { get; set; }

        public void AttackWithSecondaryWeapon(string target)
        {
            if (SecondaryWeapon != null)
            {
                SecondaryWeapon.Hit(target);
            }
        }

        private List<IItem> _items = new List<IItem>();

        public void PickupItem(IItem item)
        {
            _items.Add(item);
        }
    }
}
