using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    interface IAmmunition
    {

        // 9MM, .223, 12 Gauge
        string Cartridge { get; set; }

        Projectile Projectile { get; set; }
    }
}
