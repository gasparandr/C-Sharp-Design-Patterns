using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Player : IObserver
    {
        private string PlayerName;
        private int Wins;
        private int Losses;
        private int Rank;

        public Player(string Name)
        {
            PlayerName = Name;
            Wins = 0;
            Losses = 0;
            Rank = 0;
        }

        // The method used by the Subject to update this class
        public void Update(int W, int L, int R)
        {
            Wins = W;
            Losses = L;
            Rank = R;
        }

        public void DisplayScore()
        {
            Console.WriteLine("{0} is displaying scores: Team Wins {1} | Team Losses {2} | Team Rank {3}", PlayerName, Wins, Losses, Rank);
        }
    }
}
