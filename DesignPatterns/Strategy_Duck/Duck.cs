using System;

namespace Strategy_Duck
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public IQuackBehavior QuackBehavior
        {
            get
            {
                return quackBehavior;
            }
            set
            {
                quackBehavior = value;
            }
        }

        public IFlyBehavior FlyBehavior
        {
            get
            {
                return flyBehavior;
            }

            set
            {
                flyBehavior = value;
            }
        }

        public abstract object Display();

        public object PerformFly()
        {
            return FlyBehavior.Fly();
        }


        public object PerformQuack()
        {
            return QuackBehavior.Quacking();
        }

        public string Swim()
        {
            return "All ducks float, even decoys!!";
        }
    }
}
