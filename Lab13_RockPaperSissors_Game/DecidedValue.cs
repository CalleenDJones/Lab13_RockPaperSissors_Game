using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    class DecidedValue: Player
    {
        public override Roshambo generateRoshambo()
        {
            //Declare play as the 2nd Player's decided value

            //There can only be the following outcomes 
            //  0 - Rock
            //  1 - Paper
            //  2 - Sissors out

            Console.WriteLine("Enter R for Rock, P for Paper and S for Scissors");
            string play = Console.ReadLine().ToUpper();

            bool success = true;
            while (success)
            {
                if (play != "R" || play != "P" || play != "S")
                {
                    Console.WriteLine("ERROR. INVALID RESPONSE. Please enter R, P, or S");
                    success = false;
                }

                else if (play == "R")
                {
                    return Roshambo.Rock;
                }
                else if (play == "P")
                {
                    return Roshambo.Paper;
                }
                else
                {
                    return Roshambo.Sissors;
                }
            }
        }
    }
}
