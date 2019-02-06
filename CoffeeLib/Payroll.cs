namespace CoffeeLib
{
    public struct Payroll
    {
        public double Cost(int hours) => (hours * 12.50) + ((hours - 40) * 6.25);
    }
}
