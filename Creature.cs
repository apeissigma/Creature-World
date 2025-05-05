using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    // ENUMS
    enum SpeciesType
    {
        cat,
        bird,
        human
    }
    enum AppearanceType
    {
        fur,
        scales,
        skin,
        feathers
    }
    enum SizeType
    {
        extrasmall,
        small,
        medium,
        large
    }
    enum PersonalityType
    {
        friendly,
        hostile,
        stupid,
        chill,
        artistic,
        funny,
        smart,
        fashionable
    }

    internal class Creature
    {
        //Fields
        public string CreatureName;
        public string CreatureDescription;
        //Enums
        public SpeciesType Species = SpeciesType.cat;
        public AppearanceType Appearance = AppearanceType.fur;
        public SizeType Size = SizeType.extrasmall;
        public PersonalityType Personality = PersonalityType.friendly;

        public string Description()
        {
            return $"{CreatureName} is a {Size}, {Personality} {Species} with {Appearance}. {CreatureDescription}";
        }

        //Virtual: allows method to be overridden in derived class
        public virtual string Communicate()
        {
            return $"{CreatureName} communicates.";
        }

    }
}
