using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLib
{
    public struct Coffee
    {
        private double Price, Cost, NumberSold;

        public Coffee(Cost.CoffeeSize size, int numberSold)
        {
            Cost cost = new Cost();
            Price = cost.CoffeePrice[(int)size];
            Cost = cost.CoffeeCost[(int)size];
            NumberSold = numberSold;
        }

        public double TotalSales() => Price * NumberSold;
        public double TotalCost() => Cost * NumberSold;
        public double TotalProfit() => TotalSales() - TotalCost();
    }
}
