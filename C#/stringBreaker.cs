using System;
using System.Collections.Generic;

public static class Kata
{
  public static string StringBreakers(int n, string str)
  {
    str = str.Replace(" ", String.Empty);
    List<string> lst = new List<string>();
    for (int i = 0; i <= str.Length/n; i++)
      lst.Add("");
    for (int i = 0; i < str.Length; i++)
    {
      lst[(i/n)] += str[i];
    }
    for (int i = 0; i < lst.Count-1; i++)
    {
      lst[i] += "\n";
    }
    string s = string.Join( "", lst.ToArray());
    if (s.EndsWith("\n"))
      return s.Substring(0,s.Length-1);
    else
      return s;
  }
}
