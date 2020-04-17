using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    interface IWeapon
    {
        string Type { get; set; }

        Mag Magazine { get; set; }

        bool Fire()
        {
            if (Magazine.MagazineCapacity > 0)
            {
                Magazine.MagazineCapacity--;
                return true;
            }
            return false;
        }
    }
}
