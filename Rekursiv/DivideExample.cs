namespace Rekursiv;

public class DivideExample
{
    public static int Divide(int x, int y)
    {
        if (x >= y)
            return (1 + Divide(x - y, y));
        if(x > 0)
            Console.WriteLine("Zahl nicht teilbar Rest {0}" , x);
        return 0;
    }

    public static void Test(int a, int b)
    {
        int result = Divide(a, b);
        Console.WriteLine("{0}/{1} = Ergebnis {2}", a, b, result);
    }
}