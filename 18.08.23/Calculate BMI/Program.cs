using System;
public class Kata
{
    public static string Bmi(double weight, double height)
    {
        var bmi = weight / Math.Pow(height, 2);
        
        switch (bmi)
        {
            case <=18.5:
                return "Underweight";
            case <=25:
                return "Normal";
            case <=30:
                return "Overweight";
            case >30:
                return "Obese";
        }

        return bmi.ToString();
    }
}