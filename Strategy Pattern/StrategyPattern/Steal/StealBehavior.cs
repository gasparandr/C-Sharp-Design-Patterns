using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Steal behavior interface is being implemented in all stealing related actions, even when the person refuses to steal.
    public interface StealBehavior
    {
        void Steal();
    }
}
