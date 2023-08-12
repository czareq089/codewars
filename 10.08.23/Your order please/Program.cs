using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class Kata
{
    public static string Order(string words)
    {
        return string.Join(" ", words.Split().OrderBy(GetNum));

    }

    public static int GetNum(string input)
    {
        Match match = Regex.Match(input, @"\d+");
        return match.Success ? int.Parse(match.Value) : -1;
    }
}