namespace PGreat;

class Program
{
    public static int GreatCommonDivisor(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        else if (a < b)
            return GreatCommonDivisor(a, b - a);
        else if (a > b)
            return GreatCommonDivisor(a - b, b);
        return 0;
    }
    
    public static void Main(string[] args)
    {
        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);
        int result = GreatCommonDivisor(a, b);
        Console.WriteLine("GGT von {0}, und {1} ist {2}",a,b,result);

    }
}