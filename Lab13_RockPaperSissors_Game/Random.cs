using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    class Random : Player
    {
        //Randoms will be represented as Beans
        
        //Declares rnd as the Random generator
        static Random rnd = new Random();

        public override Roshambo generateRoshambo()
        {
            //Give the .Next values
            //  .Next random generator was utilized in Lab6 Dice Simulator

            //There can only be the following outcomes 
            //  0 - Rock
            //  1 - Paper
            //  2 - Sissors out
            if (rnd.Next(0, 2) == 0)
            {
                return Roshambo.Rock;
            }
            else if (rnd.Next(0, 2) == 1)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Sissors;
            }
        }

        private int Next(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
