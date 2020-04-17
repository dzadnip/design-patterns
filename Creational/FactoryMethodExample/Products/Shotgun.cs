﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    class Shotgun : IWeapon
    {
        public Shotgun(string Type, Mag Magazine)
        {
            this.Type = Type;
            this.Magazine = Magazine;
        }

        public string Type { get; set; }

        public Mag Magazine { get; set; }
    }
}
