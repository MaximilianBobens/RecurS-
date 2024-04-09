namespace Rekursiv;

public class GreatCommonDivisor
{
    static ulong GreatestCommonDivisor(ulong a, ulong b)
    {
        if (a == b)
            return a;
        
       else if (a < b)
            return GreatestCommonDivisor(a, b - a);
        

        else if (a > b)
            return GreatestCommonDivisor(a - b, b);
        return 0;
    }

    static ulong GreatestCommonDivisor2(ulong a, ulong b)
    {
        if (b == 0)
            return a;
        else
            return GreatestCommonDivisor(b, a % b);
    }

    public static void Test(ulong a, ulong b)
    {
        ulong result = GreatestCommonDivisor(a, b);
        Console.WriteLine("GGT von {0}, und {1} ist {2}",a,b,result);

    }
}