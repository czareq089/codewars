public static class Kata
{
    public static string Maskify(string cc)
    {
        char[] ccarray = cc.ToCharArray();
        for (int i = 0; i < cc.Length - 4; i++)
        {
            if (cc[i] != '#')
            {
                ccarray[i] = '#';
            }
        }

        cc = new string(ccarray);
        return cc;
    }

    public static void Main(string[] args)
    {
        string cc = Console.ReadLine();
        Console.WriteLine(Maskify(cc));
    }
}



