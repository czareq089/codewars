using System;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
    }

    public static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(AreYouPlayingBanjo(name));
    }
}


//// alternatywny warunek
// if (name.ToLower()[0] == 'r')
// {
//     return name + " plays banjo";
// }
// else
// {
//     return name + " does not play banjo";
