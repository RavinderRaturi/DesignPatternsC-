using System;

namespace Strategy_Pattern
{
    public  class FlyNoWay : IFlyBehavior
    {
        public FlyNoWay()
        {

        }

        public object Fly()
        {
            return "I can't fly.";
        }

    }
}
