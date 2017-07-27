using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HeatedSeats : FeatureDecorator
    {
        public HeatedSeats(Car c) : base(c)
        {
            Description = "Heated Seats";
            Price = 1330.00;
        }
    }
}
