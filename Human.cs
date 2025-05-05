using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    internal class Human : Creature, IArtist
    {
        public override string Communicate()
        {
            return $"{CreatureName} says 'hi!'";
        }

        public string MakeArt()
        {
            return $"{CreatureName} is making something cool!";
        }

    }
}
