using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            const int       MIN_RAND    = 1;
            const int       MAX_RAND    = 100;
            bool            isRunning   = true;

            Random          random      = new Random();
            GuessTheNumber  guessGame   = new GuessTheNumber();

            // Start new game and randomize a number
            guessGame.NewGame(random.Next(MIN_RAND, MAX_RAND + 1));
            
            // Welcome and instruction
            Console.Clear();
            Console.WriteLine("Välkommen till gissa numret! Numret är idag mellan {0} och {1}.", MIN_RAND, MAX_RAND);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Vilket nummer vill du gissa på?");
            
            while(isRunning)
            {
                Console.Write(": ");
                string guess = Console.ReadLine();
                
                // Set cursor with and offset from input for nicer UX fluff
                int offset = 3;
                int newCursorLeft = Console.CursorLeft + guess.Length + offset;
                Console.SetCursorPosition(newCursorLeft, Console.CursorTop -1);

                try {
                    // Try to convert input to int
                    int userGuess = Convert.ToInt32(guess);   

                    // Guess the number
                    isRunning = guessGame.Guess(userGuess);
                }
                catch {
                    Console.WriteLine("- Felinmatning...");
                } 
            }
        }
    }
}
