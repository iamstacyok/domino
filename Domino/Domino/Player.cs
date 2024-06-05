using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    internal class Player
    {
        public string Name;
        public List<Domino> Dominos = new List<Domino>();

        public Player(string name)
        {
            Name = name;
        }
    }
}
