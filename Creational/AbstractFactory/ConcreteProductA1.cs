﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factori
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
