using System.Linq;

public class Kata
{
    public static string SortMyString(string s)
    {
        string even = "";
        string odd = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 1)
            {
                odd += s[i];
            }
            else
            {
                even += s[i];
            }
        }

        return even + " " + odd;
    }
}