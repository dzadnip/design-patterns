﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
