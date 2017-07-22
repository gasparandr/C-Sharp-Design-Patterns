using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface IObserver
    {
        // Essential API that lets the Subject update the Observer
        void Update(int Wins, int Losses, int Rank);
    }
}
