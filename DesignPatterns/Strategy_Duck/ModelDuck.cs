using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Duck
{
   public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override object Display()
        {
            return "I'm a model duck";
        }

    }
}
