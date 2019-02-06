using System;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Coffee House Program \n");
            Console.WriteLine("Press any Key to begin");
            Console.ReadLine();
            while (true)
            {
                run();
            }
        }

        static void run()
        {
            ConsoleMenu menu = new ConsoleMenu();
            try
            {
                menu.ShowMenu();
            }
            catch
            {
                Console.WriteLine("Something went wrong. Lets try again \n");
            }
        }
    }
}
