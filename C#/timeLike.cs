using System;
public class Kata
{
  public static string FormatTime(int hour)
  {
    if(hour.ToString().Length < 3 || hour.ToString().Length > 4)
    {
        throw new ArgumentException();
    }
    if(hour.ToString().Length == 3)
    {
        return hour.ToString("0:00");
    }
    else
    {
        return hour.ToString("00:00");
    }
  }
}
