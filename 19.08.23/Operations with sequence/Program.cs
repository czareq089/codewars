using System;
using System.Linq;

public static class Kata
{
    public static int Calc(int[] array)
    {
        var squaredNumbers = array.Select(num => num > 0 ? num * num : num);
        var multipliedThirdNumbers = squaredNumbers.Select((num, index) => (index + 1) % 3 == 0 ? num * 3 : num);
        var multipliedFifthNumbers = multipliedThirdNumbers.Select((num, index) => (index + 1) % 5 == 0 ? num * -1 : num);
        return multipliedFifthNumbers.Sum();
    }
}