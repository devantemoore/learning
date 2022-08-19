internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //HashTableDemo.GetDemo();
        //RecursionDemo.CountDown(19);
        // Console.WriteLine(RecursionDemo.Power(2, 0));
        // Console.WriteLine(RecursionDemo.Power(2, 1));
        // Console.WriteLine(RecursionDemo.Power(2, 2));
        // Console.WriteLine(RecursionDemo.Power(2, 10));

        //SortingDemo.BubbleSort();

        SortingDemo.MergeSortDemo();
        
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

