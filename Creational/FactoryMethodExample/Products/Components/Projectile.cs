using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class Projectile
    {
        public Projectile (string Type, int Weight, string Size)
        {
            this.Type = Type;
            this.Weight = Weight;
            this.Size = Size;
        }

        public string Type { get; set; }

        public int Weight { get; set; }

        public string Size { get; set; }

    }
}
