using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    interface IProjectile
    {
        string Type { get; set; }

        int Weight { get; set; }

        string Size { get; set; }
    }
}
