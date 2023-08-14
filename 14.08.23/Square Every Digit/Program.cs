using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n) =>
        int.Parse(string.Concat(n.ToString().Select(c => Math.Pow(int.Parse(c.ToString()), 2))));
}