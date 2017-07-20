using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyPattern
    {
        static void Main(string[] args)
        {
            /*
             * STRATEGY DESIGN PATTERN
             * 
             * This design pattern is useful to delegate certain behaviors of a class to different interfaces.
             * e.g. In our case we have the base class of a politician. We know that some of them lie and steal, but that is not a general trait that can be inherited by all of the sub-classes.
             * in this case we are delegating these behaviors to interfaces which handle those behaviors (LieBehavior, StealBehavior)
             * 
             * These interfaces can have several implementations for example a LieBehavior which tells different lies or refuses to lie altogether
             * 
             * We also implemented a custom behavior which can be executed at runtime (CustomBehavior)
             */

            // We instantiate our first politician "John", who is a Minister
            Politician John = new Minister();

            // We ask John to lie and steal, and he acts according to the Minister's default traits
            Console.WriteLine("-> John lies and steals: \n");
            John.Lie();
            John.Steal();

            // However we have the ability to teach John new behaviors
            Console.WriteLine("\n-> John gets a new behavior: \n");
            John.SetCustomBehavior(new DonateToCharity());
            John.ExecuteCustomBehavior();

            // With the right implementation we could even get John to turn into a honest politician, overwriting his default behaviors with new custom ones

            // Now we instantiate our second politician "Jack", who is a honest legislator
            Politician Jack = new HonestLegislator();

            // When we ask Jack to lie, by default his principles do not let him tell a lie
            Console.WriteLine("\n-> We ask Jack to tell a lie: \n");
            Jack.Lie();

            Console.Read();
        }
    }
}
