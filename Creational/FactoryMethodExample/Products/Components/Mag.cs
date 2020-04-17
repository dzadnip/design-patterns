using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class Mag : IMagazine
    {
        public Mag (int MagazineCapacity, Ammo Ammo)
        {
            this.MagazineCapacity = MagazineCapacity;
            this.Ammunition = Ammo;
        }

        public int MagazineCapacity { get; set; }

        public Ammo Ammunition { get; set; }
    }
}
