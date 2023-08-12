char[] tekst = (Console.ReadLine()).ToArray();
for (int i = 0; i < tekst.Length; i++)
{
    int pozycja = char.ToLower(tekst[i]) - 'a' + 1;
    Console.Write(pozycja + " ");
}

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        char[] tekst = text.ToLower().ToCharArray();
        string result = "";

        for (int i = 0; i < tekst.Length; i++)
        {
            int pozycja = tekst[i] - 'a' + 1;
            if (pozycja >= 1 && pozycja <= 26)
            {
                 result += pozycja + " ";
            }


        }

        return result.Trim();
    }
}
