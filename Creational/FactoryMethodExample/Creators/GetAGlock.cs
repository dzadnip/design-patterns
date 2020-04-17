using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class GetAGlock : Weapon
    {
        private Projectile _nine_mm_projectile;
        private Ammo _nine_mm_ammo;
        private Mag _mag_with_nine_mm_ammo;
        private Glock _glock;
        private int _mag_capacity = 15;

        public override IWeapon GetAWeapon()
        {
            _nine_mm_projectile = new Projectile("Bullet", 115, "9MM");
            _nine_mm_ammo = new Ammo("9MM", _nine_mm_projectile);
            _mag_with_nine_mm_ammo = new Mag(_mag_capacity, _nine_mm_ammo);
            _glock = new Glock("Pistol", _mag_with_nine_mm_ammo);
            return _glock;
        }

        public override bool Fire()
        {
            if (_mag_with_nine_mm_ammo.MagazineCapacity > 0)
            {
                _mag_with_nine_mm_ammo.MagazineCapacity--;
                return true;
            }
            return false;
        }

        public override void Reload()
        {
            _mag_with_nine_mm_ammo.MagazineCapacity = _mag_capacity;
        }

        public override Ammo Ammo()
        {
            return _nine_mm_ammo;
        }

    }
}
