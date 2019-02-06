using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Coffee House Program \n");
            ConsoleMenu menu = new ConsoleMenu();
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
