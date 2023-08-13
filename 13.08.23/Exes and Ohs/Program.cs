using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input) => input.ToLower().Count(c => c == 'x') == input.ToLower().Count(c => c == 'o');
}