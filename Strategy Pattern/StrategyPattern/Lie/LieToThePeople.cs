using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Different types of lying implement the same interface
    public class LieToThePeople : LieBehavior
    {
        public void Lie()
        {
            Console.WriteLine("Smaller taxes in 2017.");
        }
    }
}
