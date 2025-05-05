using System.Reflection;

namespace CreatureWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Title = "Creature World!";

            World world = new World();
            world.Run();
        }
    }
}
