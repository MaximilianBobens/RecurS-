namespace Rekursiv;

public class DecimalToBinary
{
    public static string CalculateDecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";
        else if (decimalNumber == 1)
            return "1";
        else
            return CalculateDecimalToBinary(decimalNumber / 2) + (decimalNumber % 2).ToString();
    }

    public static void Test(int binaryNumber)
    {
        string result = CalculateDecimalToBinary(binaryNumber);
        Console.WriteLine("Binary Number {0}:" ,result);
    }
}