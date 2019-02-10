namespace CoffeeLib
{
    public struct Payroll
    {
        public double Cost(int hours) => (hours - 40 > 0)?(hours * 12.50) + ((hours - 40) * 6.25) : (hours * 12.50);
    }
}
