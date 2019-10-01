using System;
namespace guess_the_number
{
    class GuessTheNumber
    {
        int secretNumber    = 0;
        int guessCount      = 0;

        public void NewGame(int randomNumber)
        {
            this.secretNumber = randomNumber;
        }
        
        public bool Guess(int guess)
        {
            guessCount++;
            
            // If user guessed right, congratulate and return false to exit game
            if (guess == secretNumber) {
                Console.WriteLine("\nGrattis du gissade rätt på {0} försök! Du rockar!", guessCount);
                return false;
            }
            // If user guess was lower
            else if (guess > secretNumber) {
                Console.WriteLine("- Fel. Talet är mindre");
            }
            
            // If user guess was lower
            else if (guess < secretNumber) {
                Console.WriteLine("- Fel. Talet är större");
            }
            
            // Return true if user guessed wrong
            return true;
        }
    }
}