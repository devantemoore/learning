internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Try out the function
        Console.WriteLine(GreatestCommonDenominator(60, 96)); // should be 12
        Console.WriteLine(GreatestCommonDenominator(20, 8)); // should be 4

        
    }
    // Find GCD of two numbers using Euclid's algo
    public static int GreatestCommonDenominator(int a, int b)
    {
        while (b != 0)
        {
            var temp = a;
            a = b;
            b = temp % b;
        }
        return a;
    }
}

