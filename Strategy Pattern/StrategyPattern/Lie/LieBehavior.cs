using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Lie behavior interface is being used by all the lying related actions, even when in the scenario where we are asking a honest person to lie and they refuse.
    public interface LieBehavior
    {
        void Lie();
    }
}
