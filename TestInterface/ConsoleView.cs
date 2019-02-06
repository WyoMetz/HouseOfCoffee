using CoffeeLib;
using System;

namespace TestInterface
{
    class ConsoleView
    {
        InputValidation validation = new InputValidation();
        double sandwichCost, sandwichSales, sandwichProfit;
        double coffeeCost, coffeeSales, coffeeProfit;
        double PayrollCost;
        enum Employees { Bob, Janice, Micheal, Suzie, Alex }

        public void GetOverallCosts()
        {
            Console.WriteLine($"Your overall Costs are: \n" +
                $" Sandwich Cost is {sandwichCost:c} \n" +
                $" Coffee Cost is {coffeeCost:c} \n" +
                $" Payroll Cost is {PayrollCost:c} \n");
        }

        public void GetOverallSales()
        {
            Console.WriteLine($"Your overall sales totals are: \n" +
                $" Sandwich sales {sandwichSales:c} \n" +
                $" Coffee sales {coffeeSales:c} \n" +
                $" Total Sales {sandwichSales + coffeeSales:c} \n");
        }

        public void GetOverallProfit()
        {
            Console.WriteLine($"Your overall profit is: \n" +
                $" Sandwich profit {sandwichProfit:c} \n" +
                $" Coffee profit {coffeeProfit:c} \n" +
                $" Overall Profit is {sandwichProfit + coffeeProfit - PayrollCost:c} \n");
        }

        public void GetSandwichSales()
        {

            Cost.SandwichType sandwichType;
            Console.WriteLine("Type of Sandwiches: 1 for Egg, 2 for Chicken.");
            int type = validation.CheckInt(Console.ReadLine()) - 1;
            sandwichType = (Cost.SandwichType)type;

            Console.WriteLine($"Input the Number of {sandwichType} Sandwich sales");
            int sales = validation.CheckInt(Console.ReadLine());

            Sandwich sandwich = new Sandwich(sandwichType, sales);
            sandwichCost += sandwich.TotalCost();
            sandwichSales += sandwich.TotalSales();
            sandwichProfit += sandwich.TotalProfit();
        }

        public void GetCoffees()
        {
            Cost.CoffeeSize coffeeSize;
            Console.WriteLine("Coffee Size: 1 for small, 2 for medium, 3 for large.");
            int type = validation.CheckInt(Console.ReadLine()) - 1;
            coffeeSize = (Cost.CoffeeSize)type;

            Console.WriteLine($"Number of {coffeeSize} Coffees sold");
            int sales = validation.CheckInt(Console.ReadLine());

            Coffee coffee = new Coffee(coffeeSize, sales);
            coffeeCost += coffee.TotalCost();
            coffeeSales += coffee.TotalSales();
            coffeeProfit += coffee.TotalProfit();
        }

        public void EmployeePay()
        {
            Payroll payroll;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Number of hours worked by Employee {(Employees)i}");
                int hours = validation.CheckInt(Console.ReadLine());
                PayrollCost += payroll.Cost(hours);
            }
        }
    }
}
