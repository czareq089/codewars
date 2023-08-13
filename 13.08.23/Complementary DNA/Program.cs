public class DnaStrand
{
    public static string MakeComplement(string dna) => dna.Replace('A', 't').Replace('T', 'A').Replace('C', 'g').Replace('G', 'C').ToUpper();
}