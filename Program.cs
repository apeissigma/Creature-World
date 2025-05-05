using System.Reflection;

namespace CreatureWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Creature World!";
            Console.Title = title; 

            World world = new World();
            world.Run();
        }
    }
}
