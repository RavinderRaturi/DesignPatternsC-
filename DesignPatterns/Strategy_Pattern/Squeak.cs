using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
   public class Squeak : IQuackBehavior
    {
        public string Quacking()
        {
            return "Squeak";
        }

    }
}
