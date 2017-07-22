using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class ObserverPattern
    {
        static void Main(string[] args)
        {
            /*
             * OBSERVER DESIGN PATTERN
             * 
             * The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.
             * 
             * e.g. In our case we have a subject defined as a GameData class. This class is representing the business logic of a simple game.
             * The observers are the Players that are currently playing the game. They subscribe to the Game, and wish to be updated in real-time about the changes so they can follow the scores.
             */

            // We create an instance of the game
            GameData Game = new GameData();

            // We create player "John" and subscribe him to the game
            Player John = new Player("John");
            Game.RegisterObserver(John);

            // We create player "Jack" and subscribe him to the game
            Player Jack = new Player("Jack");
            Game.RegisterObserver(Jack);

            // Player "John" checks the game score - the game has just started there is no update coming from the subject yet
            John.DisplayScore();
            // Player "Jack" checks the game score - the game has just started there is no update coming from the subject yet
            Jack.DisplayScore();

            Console.WriteLine("\n");

            // There are some heavy calculations done in the background and the game scores get updated (we do this manually for this example)
            Game.SetScores(9, 2, 3); // Wins: 9 | Losses: 2 | Rank: 3

            // Player "John" checks the game score - at this point the game scores should be updated
            John.DisplayScore();
            // Player "Jack" checks the game score - at this point the game scores should be updated
            Jack.DisplayScore();

            Console.WriteLine("\n");

            // There are some heavy calculations done in the background and the game scores get updated once again
            Game.SetScores(23, 2, 8);

            // Player "John" checks the game score
            John.DisplayScore();
            // Player "Jack" checks the game score
            Jack.DisplayScore();

            // OPEN QUESTIONS:
            // What would happen if a new player would decide to join the game?
            // What adjustments should we implement so that whenever a new player joins they instantly get notified with the current game scores? 
            // Could the observers also be subjects in their own right? (e.g being observer in a certain context but subject in another)

            Console.Read();
        }
    }
}
