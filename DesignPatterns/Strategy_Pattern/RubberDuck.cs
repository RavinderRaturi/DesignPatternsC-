using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
   public class RubberDuck : Duck
    {

        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();

        }

        public override object Display()
        {
            return "I'm a rubber duck";
        }
    }
}
