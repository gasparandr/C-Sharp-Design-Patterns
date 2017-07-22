using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class GameData : ISubject
    {
        private List<IObserver> Observers; // This collection is where the subscribers are stored
        private int Wins;
        private int Losses;
        private int Rank;

        public GameData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o); // Adding subscribers to the list
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o); // Removing them from the list
        }

        public void NotifyObservers()
        {
            // We loop through each subscriber and execute their method with our information as parameters
            foreach (IObserver observer in Observers)
            {
                observer.Update(Wins, Losses, Rank); 
            }
        }

        public void SetScores(int W, int L, int R)
        {
            Wins = W;
            Losses = L;
            Rank = R;

            // News scores are being set, subscribers should know about it
            NotifyObservers();
        }
    }
}
