using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    internal class Location
    {
        public string LocationName;
        protected string LocationDescription;
        protected string LocationView;
        protected string Color;
        protected List<Creature> Creatures = new List<Creature>();

        public string DisplayLocation()
        {
            ChangeForeground(Color);

            StringBuilder sb = new StringBuilder();

            sb.Append($"\n=============================== {LocationName} ===============================\n");
            sb.Append($"\n{LocationDescription}\n");

            sb.Append("\nCurrent population...\n");
            foreach (Creature creature in Creatures)
            {
                sb.Append($" > {creature.Description()}\n");
            }
            sb.Append("\n");

            return sb.ToString();
        }

        public void LocationOptions()
        {
            Print("What would you like to do?");
            Print(" 1. Look around");
            Print(" 2. Interact with the creatures");
            Print(" 3. Leave");

            string choice = GetInput();

            switch (choice)
            {
                case "1":
                    LookAround();
                    break;
                case "2":
                    Interact();
                    break;
                case "3":
                    Clear();
                    Print($"You left {LocationName}.");
                    ResetConsoleColor();
                    break;
                default:
                    Print("Not a valid choice. Please try again.");
                    LocationOptions();
                    break;
            }
        }

        protected void LookAround()
        {
            Print($"\nYou look around!");
            Print($"{LocationView}");
            Print("\n");
            LocationOptions();
        }

        protected void Interact()
        {
            Print($"\nYou interacted with the creatures!");
            foreach (Creature creature in Creatures)
            {
                Print($" > {creature.Communicate()}");
            }

            Print("\n");
            LocationOptions();
        }
    }

    
}
