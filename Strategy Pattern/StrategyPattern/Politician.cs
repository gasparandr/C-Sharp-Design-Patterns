using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Politician
    {
        // Specifics of the politician
        public int Age;
        public string FirstName;
        public string LastName;

        // The politician implements interfaces for stealing and lieing, however he is able to abstain from telling a lie, or tell the truth if the sub-classes have been configured appropriately
        public LieBehavior LieBehavior;
        public StealBehavior StealBehavior;

        // THe politician can aquire new behaviors at runtime and execute them
        public CustomBehavior CustomBehavior;

        // Constructor
        public Politician()
        {
            LieBehavior = null;
            StealBehavior = null;
            CustomBehavior = null;

        }

        // The trigger for lying - a situation arised where lying can be used
        public void Lie()
        {
            if (LieBehavior != null) LieBehavior.Lie();
        }

        // The trigger for stealing - a situation arised where stealing can be used
        public void Steal()
        {
            if (StealBehavior != null) StealBehavior.Steal();
        }

        // Sets a custom behavior for the politician, one which he does not yet know how to perform
        public void SetCustomBehavior(CustomBehavior behavior)
        {
            CustomBehavior = behavior;
        }

        // Executes the custom behavior 
        public void ExecuteCustomBehavior ()
        {
            if (CustomBehavior != null) CustomBehavior.Execute();
        }
    }
}
