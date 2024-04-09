namespace PDiv;

class  Program
{
    public static int Divide(int a, int b)
    {
        if (a >= b)
            return (1 + Divide(a - b, b));
        if(a > 0)
            Console.WriteLine("Zahl nicht teilbar Rest {0}" , a);
        return 0;
    }
    public static void Main(string[] agrs)
    {
        Console.WriteLine("PDiv");
        if(agrs.Length < 2)
            Console.WriteLine("Bitte geben sie 2 Zahlen ein: ");
        else
        {
            int a = int.Parse(agrs[0]);
            int b = int.Parse(agrs[1]);
            int result = Divide(a , b);
            Console.WriteLine($"{a}/{b}={result}");
        }
       
    }
}