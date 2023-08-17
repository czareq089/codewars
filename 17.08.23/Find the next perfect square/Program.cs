using System;
 public class Kata
 {
     public static long FindNextSquare(long num) => Math.Sqrt(num) % 1 == 0 ? (long)(Math.Pow((Math.Sqrt(num) + 1), 2)) : -1;
 }