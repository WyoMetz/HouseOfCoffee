namespace CoffeeLib
{
    public struct Sandwich
    {
        private double Price, Cost, NumberSold;

        public Sandwich(Cost.SandwichType type, int numberSold)
        {
            Cost cost = new Cost();
            Price = cost.SandwichPrice[(int)type];
            Cost = cost.SandwichCost[(int)type];
            NumberSold = numberSold;
        }

        public double TotalSales() => NumberSold * Price;
        public double TotalCost() => NumberSold * Cost;
        public double TotalProfit() => TotalSales() - TotalCost();
    }
}
