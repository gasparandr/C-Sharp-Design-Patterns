using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Custom behavior interface can be injected on at runtime
    public interface CustomBehavior
    {
        void Execute();
    }
}
