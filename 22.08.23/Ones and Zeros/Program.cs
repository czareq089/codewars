using System;
using System.Linq;
namespace Solution
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray) => Convert.ToInt32(string.Join("", BinaryArray));
    }
}