using System;
using System.Text;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
      StringBuilder s = new StringBuilder();
      byte[] ascii = Encoding.ASCII.GetBytes(text);
      foreach (Byte b in ascii) 
      {
          if (b > 64 && b < 91)
            s.Append((b - 64).ToString() + " ");
          else if (b > 96 && b < 123)
            s.Append((b - 96).ToString() + " ");
      }
      s.Length--;
    return s.ToString();
  }
}
