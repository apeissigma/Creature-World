using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CreatureWorld.Library;

namespace CreatureWorld
{
    internal class World
    {
        private string Logo = @"

 __                                        | 
/   __ _  _ _|_    __ _    | | _  __ |  _| | 
\__ | (/_(_| |_|_| | (/_   |^|(_) |  | (_| o 

";
        private List<Location> Locations = new List<Location>();

        public void Run()
        {
            Intro();
            DisplayMenu();
        }

        //Constructor
        public World()
        {
            Locations.Add(new MonticelloAve());
            Locations.Add(new SchoolSt());
            Locations.Add(new TwentyFirstSt());
        }
      

        private void Intro()
        {
            Print(Logo);
            Print("Welcome to the wacky world of creatures...");
            
        }
        private void DisplayMenu()
        {
            Print("\nPlease choose a location to travel to:");

            for (int i = 0; i < Locations.Count; i++)
            {
                Print($" {i + 1}: {Locations[i].LocationName}");
            }

            var choice = GetInput();

            switch(choice)
            {
                case "1":
                    Print(Locations[0].DisplayLocation());
                    Locations[0].LocationOptions();
                    break;
                case "2":
                    Print(Locations[1].DisplayLocation());
                    Locations[1].LocationOptions();
                    break;
                case "3":
                    Print(Locations[2].DisplayLocation());
                    Locations[2].LocationOptions();
                    break;
                default:
                    Print("Not a valid option. Please try again.");
                    break;
            }

            DisplayMenu();
        }
    }
}
