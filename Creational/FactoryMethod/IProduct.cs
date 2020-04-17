using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    interface IProduct
    {
        string Operation();
    }
}
