using System;
using System.Linq;
public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        var nums = numbers.Split(' ').Select(int.Parse).ToArray();
        return $"{nums.Max()} {nums.Min()}";
    }
}