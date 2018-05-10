using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce user to game
            Console.WriteLine("Welcome to the Rock, Paper, Sissors Game!");
            Console.Write("Enter your name to play: ");

            string Player1 = (Console.ReadLine());

            bool success = true;
            while (success)
            {
                //Validate if user input alpha characters for 
                if (!TryParse(Player1))
                {
                    Console.WriteLine("ERROR. INVALID RESPONSE. Please enter your name: ");
                    success = false;
                }
            }

            Console.WriteLine("Would you like to play against the Franks or Beans?");
            //Franks are Random  and Beans are Rocks
            Console.Write("Type F for Franks or B for Beans: ");
            string Opponent = (Console.ReadLine().ToUpper());
            if (Opponent != "F" || Opponent != "B")
            {
                Console.WriteLine("ERROR, INVALID RESPONSE. Please enter F or B only ");
                success = false;
            }

            string Choice1;
            string Choice2;
            string Choice3;
            Opponent = new();





            if (Opponent == "F")
            {
               //Outline what will happen when Player1 chooses Franks
                Console.WriteLine($"{Player1}, please choose R, P, or S: ");
                Choice1 = Console.ReadLine().ToUpper();
                Console.Write($"Franks chose{}");
            }
            else (Opponent == "B")
            {
                //Outline what happens when Player1 chooses Beans
                Console.Write($"{Player1}, please choose R, P, or S: ");
                Choice2 = Console.ReadLine().ToUpper();
                Console.Write($"Franks chose{}");
            }

            //
            Console.Write($"{Player1}, please choose R, P, or S: ");
            Choice1 = Console.ReadLine().ToUpper();
            Console.Write($"Franks chose{}");

            Console.WriteLine("Would you like to play again? Enter YES or NO: ");
            string GoOn = (Console.ReadLine().ToUpper());

            if (GoOn == "NO")
            {
                Console.WriteLine($"Thanks for playing & Goodbye! " +
                    $"Press enter to exit program.");
                return;
            }
        }
        private static bool TryParse(string player1)
        {
            throw new NotImplementedException();
        }
    }
}
