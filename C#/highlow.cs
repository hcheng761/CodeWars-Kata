using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    int[] arr = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
    return arr.Max().ToString() + " " + arr.Min();
  }
}
