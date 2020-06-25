using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override object Display()
        {
            return "I'm a real Mallard duck!";
        }
    }
}
