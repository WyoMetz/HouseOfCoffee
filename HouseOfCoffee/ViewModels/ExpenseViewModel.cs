using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeLib;

namespace HouseOfCoffee.ViewModels
{
    public class ExpenseViewModel : ObservableBase
    {
        Sandwich sandwich;
        Coffee coffee;
        Payroll payroll;
        Cost cost = new Cost();

        private int smallCoffeeSales;

        private int mediumCoffeeSales;

        private int largeCoffeeSales;

        private int eggSandwichSales;

        private int chickenSandwichSales;

        private List<Employee> Employees;
    }
}
