using System;

public class Kata
{
    public static bool IsSquare(int n) => n % Math.Sqrt(n) == 0 || n == 0; //lub Math.Sqrt(n) % 1 == 0;
}