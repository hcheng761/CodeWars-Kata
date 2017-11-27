using System;
using System.Text;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    StringBuilder sb = new StringBuilder();
    int temp  = 0;
    for (int i = 0; i < str.Length; i++)
    {
      if (str[i] >=64 && str[i] <= 90)
      {
        sb.Append(str.Substring(temp,i-temp) + " ");
        temp = i;     
      }
      else if (i == str.Length-1)
        sb.Append(str.Substring(temp,i-temp+1));
    }
    if (str[str.Length-1] >=64 && str[str.Length-1] <= 90)
      sb.Append(str[str.Length-1]);
    return sb.ToString();
  }
}
