using System;
using System.Linq;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        return str.ToLower().Distinct().SequenceEqual(str.ToLower());
    }
}