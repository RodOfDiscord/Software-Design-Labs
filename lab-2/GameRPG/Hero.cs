using System.Drawing;

namespace GameRPG
{
    public class Hero : Character
    {
        public void OpenMap()
        {
            Console.WriteLine("Oppening the map");
        }

        public void Travel(string location)
        {
            Console.WriteLine($"Teleporting to {location}");
        }
    }
}
