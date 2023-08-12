public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        return new string ($"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!");
    }
}