using System;

namespace Strategy_Duck
{
    public abstract class FlyNoWay : IFlyBehavior
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
