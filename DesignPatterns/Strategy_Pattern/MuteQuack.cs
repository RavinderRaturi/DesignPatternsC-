using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
 public class MuteQuack : IQuackBehavior
    {
        public string Quacking()
        {
            return "<<silence>>";
        }
    }
}
