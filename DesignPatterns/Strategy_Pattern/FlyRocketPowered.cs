﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public FlyRocketPowered()
        { }

        public object Fly()
        {
            return "I'm flying with a rocket!";
        }
    }
}
