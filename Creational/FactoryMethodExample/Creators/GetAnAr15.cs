using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class GetAnAr15 : Weapon
    {
        private Projectile _223_projectile;
        private Ammo _223_ammo;
        private Mag _mag_with_223_ammo;
        private Ar15 _ar15;
        private int _mag_capacity = 30;

        public override IWeapon GetAWeapon()
        {
            _223_projectile = new Projectile("Bullet", 55, ".223");
            _223_ammo = new Ammo(".223", _223_projectile);
            _mag_with_223_ammo = new Mag(_mag_capacity, _223_ammo);
            _ar15 = new Ar15("Rifle", _mag_with_223_ammo);
            return _ar15;
        }

        public override bool Fire()
        {
            if (_mag_with_223_ammo.MagazineCapacity > 0)
            {
                _mag_with_223_ammo.MagazineCapacity--;
                return true;
            }
            return false;
        }

        public override void Reload()
        {
            _mag_with_223_ammo.MagazineCapacity = _mag_capacity;
        }

        public override Ammo Ammo()
        {
            return _223_ammo;
        }
    }
}
