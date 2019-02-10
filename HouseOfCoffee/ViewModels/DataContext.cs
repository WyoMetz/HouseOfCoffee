using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffee.ViewModels
{
    class DataContext : ObservableBase
    {
        public static double CoffeeCost { get; set; }
        public static double CoffeeProfit { get; set; }
        public static double CoffeeSales { get; set; }
    }
}
