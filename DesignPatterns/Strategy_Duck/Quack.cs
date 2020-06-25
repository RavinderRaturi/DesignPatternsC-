﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Duck
{
    public class Quack : IQuackBehavior
    {
        public string Quacking()
        {
            return "Quack";
        }
    }
}
