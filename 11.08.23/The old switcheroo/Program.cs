using System.Linq;
public class Kata

{
    public static string Vowel2Index(string str)
    {
        return string.Concat(str.Select((c, i) => "aeiou".Contains(c) ? (i + 1).ToString() : c.ToString()));
    }
}