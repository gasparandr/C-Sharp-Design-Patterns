using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Minister : Politician
    {
        public Minister()
        {
            LieBehavior = new LieToThePeople();
            StealBehavior = new StealEuropenFunds();
        }

    }
}
