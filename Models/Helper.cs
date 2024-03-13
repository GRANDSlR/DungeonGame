
namespace DungeonGame
{
    public class Helper
    {
        public static void PrintDevide() 
            => Console.WriteLine("------------------------------------------------");

        public static void WelcomeMessage(string name)
        {
            PrintDevide();

            Console.WriteLine($"\nWelcome to {name}!\n");

            PrintDevide();
        }
    }
}
