using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISamurai.Models;
using Ninject;

namespace DINinject.Models
{
    class Ninja
    {
        [Inject]
        public IWeapon _weapon { get; set; }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }

        private List<IItem> _items = new List<IItem>();

        [Inject]
        public void PickupItem(IItem item)
        {
            _items.Add(item);
        }
    }
}
