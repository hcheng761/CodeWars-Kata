using System;
using System.Text;
using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string low = word.ToLower();
    StringBuilder sb = new StringBuilder(word.Length);
    for (int i = 0; i < word.Length; i++)
    {
      if (i == 0 && (low.IndexOf(low[0],1) != -1))
        sb.Append(')');
      else if (i != 0 && (low.IndexOf(low[i],i+1) != -1 || checkBackwards(low[i],low,i) == true))
        sb.Append(')');
      else
        sb.Append('(');
    }
    return sb.ToString();
  }
  
  public static bool checkBackwards(char c, string s, int index)
  {
    for (int i = 0; i < index; i++)
    {
      if (s[i] == c)
        return true;
    }
    return false;
  }
}
