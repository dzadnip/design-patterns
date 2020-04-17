using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    interface IMagazine
    {
        int MagazineCapacity { get; set; }
        Ammo Ammunition { get; set; }
    }
}
