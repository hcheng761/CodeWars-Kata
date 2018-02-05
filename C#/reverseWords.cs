using System;
using System.Text;
using System.Linq;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string[] words = str.Split(null);
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < words.Length; i++)
    {
      sb.Append(new string(words[i].ToCharArray().Reverse().ToArray()) + " ");
    }
    return sb.ToString().Substring(0,str.Length);
  }
}
