using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    abstract class Weapon
    {

        public abstract IWeapon GetAWeapon();

        public abstract bool Fire();

        public abstract void Reload();

        public abstract Ammo Ammo();
    }
}
