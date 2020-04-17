using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class GetAShotGun : Weapon
    {
        private Projectile _12_gauge_shots;
        private Ammo _12_gauge_shells;
        private Mag _mag_with_12_gauge_ammo;
        private Shotgun _shotgun;
        private int _mag_capacity = 8;

        public override IWeapon GetAWeapon()
        {
            _12_gauge_shots = new Projectile("Shots", 3, "8.4");
            _12_gauge_shells = new Ammo("12 Gauge", _12_gauge_shots);
            _mag_with_12_gauge_ammo = new Mag(_mag_capacity, _12_gauge_shells);
            _shotgun = new Shotgun("Shotgun", _mag_with_12_gauge_ammo);
            return _shotgun;
        }

        public override bool Fire()
        {
            if (_mag_with_12_gauge_ammo.MagazineCapacity > 0)
            {
                _mag_with_12_gauge_ammo.MagazineCapacity--;
                return true;
            }
            return false;
        }

        public override void Reload()
        {
            _mag_with_12_gauge_ammo.MagazineCapacity = _mag_capacity;
        }

        public override Ammo Ammo()
        {
            return _12_gauge_shells;
        }
    }
}
