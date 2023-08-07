using System;
using System.Collections.Generic;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        List<int> numbers = new List<int>();
        while (num > 0)
        {
            numbers.Add(num % 10);
            num /= 10;
        }
        numbers.Sort();
        numbers.Reverse();
        string concatenated = string.Join("", numbers);
        
        int result;
        if (int.TryParse(concatenated, out result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine(DescendingOrder(number));
            }
            else
            {
                Console.WriteLine("Invalid input format.");
            }
        }
    }
}