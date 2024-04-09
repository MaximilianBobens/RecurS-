namespace Rekursiv;

public class FakutorialExample
{
    static long Factorial(long n)
    {
        if (n > 0)
        {
            return n * Factorial(n - 1);
        }

        return 1;
    }

    public static void Test(long num)
    {
        long result = Factorial(num);
        Console.WriteLine("Fakualtät von {0} = {1}",num,result);
    }
}