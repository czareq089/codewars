using System;
public static class Kata
{
    public static bool Narcissistic(int value)
    {
        string valueStr = value.ToString();
        int length = valueStr.Length;
        int sum = 0;

        foreach (char c in valueStr)
        {
            int num = int.Parse(c.ToString());
            sum += (int)Math.Pow(num, length);
        }

        return sum == value;
    }
    
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool isNarcissistic = Narcissistic(number);
        Console.WriteLine(isNarcissistic);
    }
}

