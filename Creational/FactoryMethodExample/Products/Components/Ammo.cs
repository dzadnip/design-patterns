using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class Ammo : IAmmunition
    {
        public Ammo (string Cartridge, Projectile Projectile)
        {
            this.Cartridge = Cartridge;
            this.Projectile = Projectile;
        }

        public string Cartridge { get; set; }

        public Projectile Projectile { get; set; }

    }
}
