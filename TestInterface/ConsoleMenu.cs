using System;

namespace TestInterface
{
    class ConsoleMenu
    {
        InputValidation validation = new InputValidation();
        ConsoleView view = new ConsoleView();
        public void ShowMenu()
        {
            view.GetOverallCosts();
            view.GetOverallSales();
            view.GetOverallProfit();
            Console.WriteLine("Main Menu \n" +
                "Enter 'Coffee' to input Coffee sales \n" +
                "Enter 'Sandwich' to input Sandwich sales \n" +
                "Enter 'Payroll' to input Payroll hours \n" +
                "Or enter 'Exit' to Exit the program \n");
            Console.Write("HouseOfCoffee> ");
            string input = validation.CheckString(Console.ReadLine());
            if (input.ToLower().Contains("coffee"))
            {
                CoffeeInput();
            }
            else if (input.ToLower().Contains("sandwich"))
            {
                SandwichInput();
            }
            else if (input.ToLower().Contains("payroll"))
            {
                EmployeePayroll();
            }
            else if (input.ToLower().Contains("exit"))
            {
                Console.Clear();
                Console.WriteLine("Did you want to exit? ( y / n )");
                Console.Write("HouseOfCoffee> ");
                string exit = validation.CheckString(Console.ReadLine());
                if (exit.ToLower().Contains("y"))
                {
                    Console.WriteLine("Thanks For using the House Of Coffee App!");
                    Console.ReadLine();
                    Environment.Exit(Environment.ExitCode);
                }
                else
                {
                    Console.Clear();
                    ShowMenu();
                }
            }
            else
            {
                Console.WriteLine("Sorry, didn't recognise the Command");
                ShowMenu();
            }
        }

        private void CoffeeInput()
        {
            Console.Clear();
            view.GetCoffees();
            Console.WriteLine("Add more Coffee Sales? (y / n)");
            string input = validation.CheckString(Console.ReadLine());
            if (input.ToLower().Contains("y"))
            {
                CoffeeInput();
            }
            Console.Clear();
            ShowMenu();
        }

        private void SandwichInput()
        {
            Console.Clear();
            view.GetSandwichSales();
            Console.WriteLine("Add more Sandwich Sales? (y / n)");
            string input = validation.CheckString(Console.ReadLine());
            if (input.ToLower().Contains("y"))
            {
                SandwichInput();
            }
            Console.Clear();
            ShowMenu();
        }

        private void EmployeePayroll()
        {
            Console.Clear();
            view.EmployeePay();
            Console.Clear();
            ShowMenu();
        }
    }
}
