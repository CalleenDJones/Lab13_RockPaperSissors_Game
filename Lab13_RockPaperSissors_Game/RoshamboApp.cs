using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    class RoshamboApp: Player
    {
        public override Roshambo generateRoshambo()
        {
            //Give the generateRoshambo functionality
            
            //return Roshambo.Rock;
            return Roshambo.Paper;
        }
    }
}
