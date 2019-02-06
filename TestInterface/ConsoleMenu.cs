using System;

namespace TestInterface
{
    class ConsoleMenu
    {
        InputValidation validation = new InputValidation();
        ConsoleView view = new ConsoleView();
        public void ShowMenu()
        {
            Console.WriteLine("Main Menu \n" +
                "Enter 'Coffee' to input Coffee sales \n" +
                "Enter 'Sandwich' to input Sandwich sales \n" +
                "Enter 'Payroll' to input Payroll hours \n" +
                "Enter 'Profit' to view overall profit \n" +
                "Or enter 'Exit' to Exit the program \n");
            string input = validation.CheckString(Console.ReadLine());
            if (input.ToLower().Contains("coffee"))
            {
                CoffeeInput();
            }
            if (input.ToLower().Contains("sandwich"))
            {
                SandwichInput();
            }
            if (input.ToLower().Contains("payroll"))
            {
                EmployeePayroll();
            }
            if (input.ToLower().Contains("profit"))
            {
                Console.Clear();
                view.GetOverallCosts();
                view.GetOverallSales();
                view.GetOverallProfit();
            }
            Console.WriteLine("Thanks For using the Coffee House App!");
            Console.ReadLine();
            Environment.Exit(Environment.ExitCode);
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
            ShowMenu();
        }
    }
}
