using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Honest : LieBehavior
    {
        public void Lie()
        {
            Console.WriteLine("I cannot tell a lie…");
        }
    }
}
