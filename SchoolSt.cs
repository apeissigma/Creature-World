using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureWorld
{
    internal class SchoolSt : Location
    {
        public SchoolSt()
        {
            LocationName = "School Street Place";
            LocationDescription = "A big, sunny Avondale apartment on the third floor.";
            LocationView = "Ahnali's at the kitchen table. June and Zoey are on the couch.";
            Color = "blue";
            Creatures = new List<Creature>()
            {
                new Cat()
                {
                    CreatureName = "Zoey",
                    CreatureDescription = "She's got a funny face!",
                    Species = SpeciesType.cat,
                    Appearance = AppearanceType.fur,
                    Size = SizeType.small,
                    Personality = PersonalityType.chill
                }, //close Cat()
                new Human()
                {
                    CreatureName = "Ahnali",
                    CreatureDescription = "She's probably working on her thesis...",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.smart
                }, //close Human()
                new Human()
                {
                    CreatureName = "June",
                    CreatureDescription = "Ask her about all the books she's read!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.smart
                } //close Human()        
            }; //close Creatures
        }//close constructor
    }
}
