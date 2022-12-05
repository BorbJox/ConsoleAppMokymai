using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Hangman
    {
        string[] dictionary =
        {
            "combination",
            "transportation",
            "hotel",
            "person",
            "message",
            "importance",
            "idea",
            "passion",
            "science",
            "memory",
            "driver",
            "heart",
            "tale",
            "marketing",
            "photo",
            "thing",
            "drama",
            "celebration",
            "food",
            "warning",
        };
        char[] wrongGuesses = Array.Empty<char>();
        string chosenWord = "";
        string guessedWord = "";
        char lastGuess = ' ';
        int lives = 6;

        public bool Start()
        {
            Hangman.DrawTitle();
            PickWord();
            while(lives > 0 && !HasWon())
            {
                DrawGuess();
                DrawArt();
                DrawWrongGuesses();
                ReadGuess();
                CheckGuess();
            }

            if (lives == 0)
            {
                Console.WriteLine("GAME OVER\r\nYou Lost.");
            } else if (HasWon())
            {
                Console.WriteLine("CONGRATULATIONS!\r\nYou Won!");
            }

            Console.WriteLine("The word was: {0}", chosenWord);
            Console.WriteLine("Try again? (y/n)");
            char pressed = Char.ToLower(Console.ReadKey().KeyChar);
            if (pressed == 'y')
            {
                Reset();
                return true;
            } else
            {
                return false;
            }
        }

        private static void DrawTitle()
        {
            Console.WriteLine("\r\n\r\nWelcome to...\r\nH A N G M A N");
        }

        private void CheckGuess()
        {
            if (chosenWord.Contains(lastGuess))
            {
                Console.WriteLine("Correct!");
                for (int i = 0; i < chosenWord.Length; i++)
                { 
                    if (chosenWord[i] == lastGuess)
                    {
                        char[] tempCharArray = Array.Empty<char>();
                        for (int j = 0; j < guessedWord.Length; j++)
                        {
                            if (i == j)
                            {
                                tempCharArray = (char[])tempCharArray.Append<char>(chosenWord[j]).ToArray();
                            }
                            else
                            {
                                tempCharArray = (char[])tempCharArray.Append<char>(guessedWord[j]).ToArray();
                            }
                        }
                        guessedWord = new string(tempCharArray);
                    }
                }
            } else
            {
                Console.WriteLine("Wrong.");
                lives--;
                Array.Resize<char>(ref wrongGuesses, wrongGuesses.Length + 1);
                wrongGuesses[wrongGuesses.Length - 1] = lastGuess;
            }
        }

        private void DrawWrongGuesses()
        {
            Console.WriteLine("Wrong guesses: {0}", new string(wrongGuesses));
        }

        private void ReadGuess()
        {
            Console.WriteLine("Guess a letter...");
            char pressed = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (!this.IsValidGuess(pressed))
            {
                ReadGuess();
            }
        }

        private bool IsValidGuess(char guess)
        {
            if ((int)guess > 122 || (int)guess < 97)
            {
                Console.WriteLine("Unknown key pressed. Try again.");
                return false;
            }
            else if (wrongGuesses.Contains<char>(guess))
            {
                Console.WriteLine("You already guessed this letter wrong! Try again.");
                return false;
            }
            else if (guessedWord.Contains<char>(guess))
            {
                Console.WriteLine("You already guessed this letter correct! Try again.");
                return false;
            }
            else
            {
                lastGuess = guess;
                return true;
            }
        }

        private void Reset()
        {
            lives = 6;
            wrongGuesses = Array.Empty<char>();
            chosenWord = "";
            guessedWord = "";
            lastGuess = ' ';
        }

        private bool HasWon()
        {
            return guessedWord == chosenWord;
        }

        private void PickWord()
        {
            Random rnd = new Random();
            chosenWord = dictionary[rnd.Next(dictionary.Length)];
            guessedWord = new string('_', chosenWord.Length);
        }

        private void DrawGuess()
        {
            Console.WriteLine(guessedWord);
        }

        private void DrawArt()
        {
            switch (lives)
            {
                case 6:
                    Console.Write(
@"
 +---+
     |
     |
     |
    ===
");
                    break;
                case 5:
                    Console.Write(
@"
 +---+
 O   |
     |
     |
    ===
");
                    break;
                case 4:
                    Console.Write(
@"
 +---+
 O   |
 |   |
     |
    ===
");
                    break;
                case 3:
                    Console.Write(
@"
 +---+
 O   |
/|   |
     |
    ===
");
                    break;
                case 2:
                    Console.Write(
@"
 +---+
 O   |
/|\  |
     |
    ===
");
                    break;
                case 1:
                    Console.Write(
@"
 +---+
 O   |
/|\  |
/    |
    ===
");
                    break;
                default:
                    Console.Write(
@"
 +---+
 O   |
/|\  |
/ \  |
    ===
");
                    break;
            }
        }
    }
}