public static class RecursionDemo{
    // typically used for searching and sorting datasets
    public static void CountDown(int n){
        if ( n == 0 ){
            Console.WriteLine("Done!");
            return;
        }
        Console.Write(n + "...");
        CountDown(n - 1);
        Console.Write(n + "...");
    }

    // use recursion to return the baseNumber to the power of the exponent
    public static int Power(int baseNumber, int exponent){
        if (exponent == 0) return 1;
        if (exponent == 1) return baseNumber;

        return baseNumber * Power(baseNumber, exponent -1);
    }

    // use recursion to find the factorial of a given number
    public static int factorial(int number){
        if ( number == 0 ) return 1;
        if ( number == 1 ) return 1;
        //if ( number == 2 ) return 2;

        return number * factorial(number - 1);
    }
}