using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Different types of lying implement the same interface
    public class LieToTheMedia : LieBehavior
    {
        public void Lie()
        {
            Console.WriteLine("We are operating with the interest of the people at heart.");
        }
    }
}
