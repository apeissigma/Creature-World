using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    internal class Cat : Creature
    {
        //Method overriding communicate()
        public override string Communicate()
        {
            return $"{CreatureName} meows.";

            //Returns what the base class does
            //return base.Communicate();
        }
    }
}
