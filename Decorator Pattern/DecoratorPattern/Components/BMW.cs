using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Bmw : Car
    {
        public Bmw()
        {
            Description = "Bmw";
        }

        public override double Cost()
        {
            return 37200.00;
        }
    }
}
