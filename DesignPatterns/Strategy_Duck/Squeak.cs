using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Duck
{
   public class Squeak : IQuackBehavior
    {
        public string Quacking()
        {
            return "Squeak";
        }

    }
}
