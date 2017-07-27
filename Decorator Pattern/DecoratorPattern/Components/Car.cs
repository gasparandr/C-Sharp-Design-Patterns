using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // This abstract class gets extended by all the Concrete Components (car brands)
    public abstract class Car
    {
        public string Description = "Unknown Car";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
