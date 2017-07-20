using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Different types of stealing implement the same interface
    public class StealHealthcareFunds : StealBehavior
    {
        public void Steal()
        {
            Console.WriteLine("I'm stealing money!");
        }
    }
}
