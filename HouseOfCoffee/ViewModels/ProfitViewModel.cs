using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeLib;
using HouseOfCoffee.Models;
using System.Windows.Input;
using HouseOfCoffee.ViewModel;

namespace HouseOfCoffee.ViewModels
{
    class ProfitViewModel : ObservableBase, ICommand
    {
        Employee employee = new Employee();
        public ProfitViewModel()
        {
            employees = employee.GetEmployees();
        }

        #region Coffee
        private double coffeeProfit;
        public double CoffeeProfit
        {
            get { return coffeeProfit; }
            set { coffeeProfit = value; OnPropertyChanged("CoffeeProfit"); }
        }

        private double coffeeCost;
        public double CoffeeCost
        {
            get { return coffeeCost; }
            set { coffeeCost = value; OnPropertyChanged("CoffeeCost"); }
        }

        private double coffeeSales;
        public double CoffeeSales
        {
            get { return coffeeSales; }
            set
            {
                coffeeSales = value;
                OnPropertyChanged("CoffeeSales");
            }
        }

        private int smallCoffeeSales;
        public int SmallCoffeeSales
        {
            get { return smallCoffeeSales; }
            set
            {
                smallCoffeeSales = value;
                OnPropertyChanged("SmallCoffeeSales");
                setIncome();
            }
        }

        private int mediumCoffeeSales;
        public int MediumCoffeeSales
        {
            get { return mediumCoffeeSales; }
            set
            {
                mediumCoffeeSales = value;
                OnPropertyChanged("MediumCoffeeSales");
                setIncome();
            }
        }

        private int largeCoffeeSales;
        public int LargeCoffeeSales
        {
            get { return largeCoffeeSales; }
            set
            {
                largeCoffeeSales = value;
                OnPropertyChanged("LargeCoffeeSales");
                setIncome();
            }
        }

        #endregion

        #region Sandwich
        private double sandwichSales;
        public double SandwichSales
        {
            get { return sandwichSales; }
            set { sandwichSales = value; OnPropertyChanged("SandwichSales"); }
        }

        private double sandwichCost;
        public double SandwichCost
        {
            get { return sandwichCost; }
            set { sandwichCost = value; OnPropertyChanged("SandwichCost"); }
        }

        private double sandwichProfit;
        public double SandwichProfit
        {
            get { return sandwichProfit; }
            set { sandwichProfit = value; OnPropertyChanged("SandwichProfit"); }
        }

        private int eggSandwich;
        public int EggSandwich
        {
            get { return eggSandwich; }
            set
            {
                eggSandwich = value;
                OnPropertyChanged("EggSandwich");
                setIncome();
            }
        }

        private int chickenSandwich;
        public int ChickenSandwich
        {
            get { return chickenSandwich; }
            set
            {
                chickenSandwich = value;
                OnPropertyChanged("ChickenSandwich");
                setIncome();
            }
        }

        #endregion

        #region Payroll
        private double payrollCost;
        public double PayrollCost
        {
            get { return payrollCost; }
            set { payrollCost = value; OnPropertyChanged("PayrollCost"); }
        }

        private List<Employee> employees;
        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
                setIncome();
            }
        }
        #endregion

        #region IncomeSets
        private double totalIncome;
        public double TotalIncome
        {
            get
            {
                return totalIncome;
            }
            set
            {
                totalIncome = value;
                OnPropertyChanged("TotalIncome");
            }
        }


        private void setIncome()
        {
            Payroll payroll;
            double tempPayroll=0;
            foreach (var emp in Employees)
            {
                tempPayroll += payroll.Cost(emp.HoursWorked);
            }
            PayrollCost = tempPayroll;
            setCoffee();
            setSandwich();
            TotalIncome = CoffeeProfit + SandwichProfit - PayrollCost;
        }

        private void setCoffee()
        {
            Coffee small = new Coffee(Cost.CoffeeSize.small, smallCoffeeSales);
            Coffee medium = new Coffee(Cost.CoffeeSize.medium, mediumCoffeeSales);
            Coffee large = new Coffee(Cost.CoffeeSize.large, largeCoffeeSales);

            CoffeeSales = small.TotalSales() + medium.TotalSales() + large.TotalSales();
            CoffeeCost = small.TotalCost() + medium.TotalCost() + large.TotalCost();
            CoffeeProfit = small.TotalProfit() + medium.TotalProfit() + large.TotalProfit();
        }

        private void setSandwich()
        {
            Sandwich EggSandwich = new Sandwich(Cost.SandwichType.Egg, eggSandwich);
            Sandwich ChickenSandwich = new Sandwich(Cost.SandwichType.ChickenBiscuit, chickenSandwich);

            SandwichSales = EggSandwich.TotalSales() + ChickenSandwich.TotalSales();
            SandwichCost = EggSandwich.TotalCost() + ChickenSandwich.TotalCost();
            SandwichProfit = EggSandwich.TotalProfit() + ChickenSandwich.TotalProfit();
        }

        #endregion

        public ICommand Update
        {
            get { return new RelayCommand(execute => Execute("Value"), canExecute => CanExecute("Value")); }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            setIncome();
        }
    }
}
