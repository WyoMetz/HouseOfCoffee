using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeLib;
using HouseOfCoffee.ViewModels;

namespace HouseOfCoffee.Models
{
    public class Employee : ObservableBase
    {
        Payroll payroll;

        private double payrollCost;
        public double PayrollCost
        {
            get { return payrollCost; }
            set
            {
                payrollCost = value;
                OnPropertyChanged("PayrollCost");
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private int hoursWorked;
        public int HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                hoursWorked = value;
                OnPropertyChanged("HoursWorked");
                PayrollCost += payroll.Cost(hoursWorked);
            }
        }
        enum EmployeeName { Janice, Alex, Bob, Alice, James }
        
        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Employee
                {
                    Name = $"{(EmployeeName)i}"
                });
            }
            return list;
        }
    }
}
