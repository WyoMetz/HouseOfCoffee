using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    public class InputValidation
    {
        public int CheckInt(string input)
        {
            try
            {
                int value = int.Parse(input);
                if (value > 0)
                {
                return value;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number");
                    return CheckInt(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return CheckInt(Console.ReadLine());
            }
        }

        public string CheckString(string input)
        {
            try
            {
                int value = int.Parse(input);
                Console.WriteLine("Please enter a valid word");
                return CheckString(Console.ReadLine());
            }
            catch
            {
                return input;
            }
        }
    }
}
