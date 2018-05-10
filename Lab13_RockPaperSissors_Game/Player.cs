using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RockPaperSissors_Game
{
    abstract class Player
    {
        //Stores a name
        private string name;
        private Roshambo roshambo;

        public string Name { get => name; set => name = value; }
        public Roshambo Roshambo { get => roshambo; set => roshambo = value; }


        public abstract Roshambo generateRoshambo();

    }

}
