using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class Ar15 : IWeapon
    {
        public Ar15(string Type, Mag Magazine)
        {
            this.Type = Type;
            this.Magazine = Magazine;
        }

        public string Type { get; set; }

        public Mag Magazine { get; set; }
    }
}
