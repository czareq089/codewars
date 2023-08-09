using System;
using System.Collections;
using System.Linq;

public class TwoToOne 
{
  
    public static string Longest (string s1, string s2)
    {
        string connected = string.Concat(s1, s2);
        var dist = connected.Distinct();
        string result = new string(dist.ToArray());
        result = new string(result.OrderBy(c => c).ToArray());
        return result;
    }
    public static void Main(string[] args)
    {
        string w1 = Console.ReadLine();
        string w2 = Console.ReadLine();
        Console.WriteLine(Longest(w1, w2));
    }
}