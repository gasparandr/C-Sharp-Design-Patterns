using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class WindowTint : FeatureDecorator
    {

        public WindowTint(Car c) : base(c)
        {
            Description = "Tinted Windows";
            Price = 890.00;
        }
    }
}
