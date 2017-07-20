using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class DonateToCharity : CustomBehavior
    {
        public void Execute()
        {
            Console.WriteLine("Donating to charity!");
        }
    }
}
