using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // This abstract class gets extended by all the Concrete Features (e.g. tinted windows, heated seats etc.)
    public abstract class FeatureDecorator : Car
    {
        protected Car Car;
        protected double Price;

        public FeatureDecorator(Car c)
        {
            Car = c;
        }

        public override string GetDescription()
        {
            return Car.GetDescription() + ", " + Description;
        }

        public override double Cost()
        {
            return Price + Car.Cost();
        }
    }
}
