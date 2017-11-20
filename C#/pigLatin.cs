using System;
using System.Text;

public class Kata
{
  public static string PigIt(string str)
  {
    StringBuilder sb = new StringBuilder();
    int temp = 0;
    for (int i = 0; i < str.Length; i++)
    {
      if (str[i] == ' ')
      {
        sb.Append(str.Substring(temp+1,i-temp-1) + str[temp] + "ay ");
        temp = i+1;
      }
      else if (i == str.Length-1)
        sb.Append(str.Substring(temp+1, i-temp) + str[temp] + "ay");
    }
    return sb.ToString();
  }
}
