public class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        string result = "";
        foreach (var c in word)
        {
            if (word.IndexOf(c) == word.LastIndexOf(c)) // IndexOf pierwszą zarejestrowaną oznacza pozycje litery c, LastIndex ostatnią, jeśli są równe to litera pojawiła się tylko raz 
            {
                result += "(";
            }
            else
            {
                result += ")";
            }
        }

        return result;
    }
}