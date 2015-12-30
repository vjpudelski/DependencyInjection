using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISamurai.Models;
using Ninject;

namespace DINinject.Models
{
    public class Ninja
    {
        [Inject]
        public IWeapon Weapon { get; set; }

        private List<IItem> _items = new List<IItem>();

        [Inject]
        public void PickupItem(IItem[] items)
        {
            _items.AddRange(items);
        }
    }
}
