namespace Rekursiv;

public class FibonacciExample
{
    static long Fibonacci(long n)
    {
        return (n <= 1) ? n : Fibonacci(n - 2) + Fibonacci(n - 1);
    }

    public static void Test(int num)
    {
        Console.WriteLine("Fibonacci {0}",num);
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("{0},",Fibonacci(i));
            Console.WriteLine();
        }
    }
}