using System.Runtime.CompilerServices;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hangman game = new Hangman();
            bool keepGoing = true;
            while (keepGoing)
            {
                keepGoing = game.Start();
            }          
        }
    }
}