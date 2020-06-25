using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Duck
{
   public class FlyWithWings : IFlyBehavior
    {

        public object Fly()
        {
            return "I'm flying!!";
        }
    }
}
