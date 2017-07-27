using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Lexus : Car
    {
        public Lexus()
        {
            Description = "Lexus";
        }

        public override double Cost()
        {
            return 27300.00;
        }
    }
}
