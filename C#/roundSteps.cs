using System;
using System.Text;

public class Kata
{
  public static double Solution(double n)
  {
    n -= 0.25;
    double dec = n - Math.Floor(n);
    if (dec < 0.50)
      return n + (0.50 - dec);
    else if (dec > 0.50 && dec < 1.00)
      return n + (1.0 - dec);
    return -1;
  }
}
