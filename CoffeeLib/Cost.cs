namespace CoffeeLib
{
    public class Cost
    {
        public enum CoffeeSize { small, medium, large }
        public double[] CoffeePrice = { 1.00, 3.00, 4.00 };
        public double[] CoffeeCost = { .10, .15, .20 };

        public enum SandwichType { Egg, ChickenBiscuit }
        public double[] SandwichPrice = { 5.50, 7.50 };
        public double[] SandwichCost = { .95, 1.20 };
    }
}
