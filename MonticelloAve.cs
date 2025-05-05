using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureWorld
{
    internal class MonticelloAve : Location
    {
        public MonticelloAve()
        {
            LocationName = "Monticello Ave Place";
            LocationDescription = "An apartment in Avondale that's never quiet...";
            LocationView = "Some folks are in the sunroom, others are in the kitchen.";
            Color = "green";
            Creatures = new List<Creature>()
            {
                new Cat()
                {
                    CreatureName = "Ernie",
                    CreatureDescription = "He sure stinks!",
                    Species = SpeciesType.cat,
                    Appearance = AppearanceType.fur,
                    Size = SizeType.small,
                    Personality = PersonalityType.friendly
                }, //close Cat()
                new Bird()
                {
                    CreatureName = "Dino",
                    CreatureDescription = "So cute!",
                    Species = SpeciesType.bird,
                    Appearance = AppearanceType.feathers,
                    Size = SizeType.extrasmall,
                    Personality = PersonalityType.stupid
                }, //close Bird()
                new Human()
                {
                    CreatureName = "Asha",
                    CreatureDescription = "He'll probably offer you some tea!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.chill
                }, //close Human()
                new Human()
                {
                    CreatureName = "Ezra",
                    CreatureDescription = "He's a great cook!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.artistic
                }, //close Human()
                new Human()
                {
                    CreatureName = "Timmy",
                    CreatureDescription = "Ask him about fashion!",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.fashionable
                }, //close Human()
                new Human()
                {
                    CreatureName = "Kapka",
                    CreatureDescription = "He doesn't live here, but he's here anyway.",
                    Species = SpeciesType.human,
                    Appearance = AppearanceType.skin,
                    Size = SizeType.large,
                    Personality = PersonalityType.funny
                } //close Human()
            }; //close new list
        }//close constructor
    }
}