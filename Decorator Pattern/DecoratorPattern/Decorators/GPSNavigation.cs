using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class GPSNavigation : FeatureDecorator
    {
        public GPSNavigation(Car c) : base(c)
        {
            Description = "GPS Navigation System";
            Price = 1920.00;
        }
    }
}
