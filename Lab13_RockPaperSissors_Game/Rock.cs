using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    class Rock: Player 
    {
        //Rock will be represented as Franks

        //Player will always select Rock
        public override Roshambo generateRoshambo()
        {
            //Give the generateRoshambo functionality
            //these will return same thing
            //return Roshambo.Rock;
            //return (Roshambo)0;
            return Roshambo.Rock;
        }

    }
}
