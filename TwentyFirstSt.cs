using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureWorld
{
    internal class TwentyFirstSt : Location
    {
        public TwentyFirstSt()
        {
            LocationName = "Twenty First St Place";
            LocationDescription = "This apartment used to be an old school house!";
            LocationView = "Mazzy and Burger are on the couch and Lithe's on her computer.";
            Color = "red";
            Creatures = new List<Creature>()
            {
                new Cat()
                {
                    CreatureName = "Burger",
                    CreatureDescription = "He's a hairless cat... So ugly...",
                    Species = SpeciesType.cat,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.small,
                    Personality = PersonalityType.stupid
                }, //close Cat()
                new Human()
                {
                    CreatureName = "Mazzy",
                    CreatureDescription = "They're Mazzy!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.funny
                }, //close Human()
                new Human()
                {
                    CreatureName = "Lithe",
                    CreatureDescription = "She plays electric guitar!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.chill
                } //close Human()        
            }; //close Creatures
        }//close constructor
    }
}
