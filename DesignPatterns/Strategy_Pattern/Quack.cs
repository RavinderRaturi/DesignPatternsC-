using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class Quack : IQuackBehavior
    {
        public string Quacking()
        {
            return "Quack";
        }
    }
}
