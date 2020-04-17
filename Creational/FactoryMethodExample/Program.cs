using System;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Weapon ar15 = new GetAnAr15();
            ar15.GetAWeapon();

            for (int i = 0; i < 31; i++)
            {
                FireWeapon(ar15);
            }


            Weapon glock = new GetAGlock();
            glock.GetAWeapon();

            for (int i = 0; i < 18; i++)
            {
                FireWeapon(glock);
            }
            ReloadWeapon(glock);
            for (int i = 0; i < 3; i++)
            {
                FireWeapon(glock);
            }


            Weapon shotgun = new GetAShotGun();
            shotgun.GetAWeapon();

            for (int i = 0; i < 5; i++)
            {
                FireWeapon(shotgun);
            }

        }

        static void FireWeapon(Weapon weapon)
        {
            if (weapon.Fire())
            {
                Console.WriteLine($"Bang! Fired a {weapon.Ammo().Projectile.Size} {weapon.Ammo().Projectile.Type}");
            } else
            {
                Console.WriteLine($"Empty! Please Reload!");
            }
            
        }

        static void ReloadWeapon(Weapon weapon)
        {
            weapon.Reload();
        }
    }
}
