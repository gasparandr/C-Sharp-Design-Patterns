using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DecoratorPattern
    {
        static void Main(string[] args)
        {
            /*
             * DECORATOR DESIGN PATTERN
             * 
             * The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
             * 
             * e.g. In our case we use two concrete components (a BMW and a Lexus) and we decorate them with different features (Tinted Windows, Heated Seats and GPS Navigation).
             * This will naturally affect the cost of our vehicle, so basically the more features we add to it the more expensive the vehicle's price will become.
             * 
             */

            // We start with a Lexus
            Car lexus = new Lexus();
            Console.WriteLine("Lexus base price is: $" + lexus.Cost());
            // Now we decorate it with the features (each feature increments the total cost of the vehicle)
            lexus = new WindowTint(lexus);
            lexus = new GPSNavigation(lexus);

            Console.WriteLine(lexus.GetDescription() + " >> TOTAL COST: $" + lexus.Cost() + "\n");

            // Let's do the same thing with a BMW
            Car bmw = new Bmw();
            Console.WriteLine("BMW base price is: $" + bmw.Cost());
            // Decorating it with the features
            bmw = new WindowTint(bmw);
            bmw = new HeatedSeats(bmw);
            bmw = new GPSNavigation(bmw);

            Console.WriteLine(bmw.GetDescription() + " >> TOTAL COST: $" + bmw.Cost());

            // We could continue extending the code with different car models and different features.
            // Using the decorator pattern on it's own can be sometimes tedious, but in conjunction with the Factory Pattern it creates a great design.

            Console.Read();
        }
    }
}
