using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    internal class Bird : Creature
    {
        public override string Communicate()
        {
            return $"{CreatureName} chirps.";
        }
    }
}
