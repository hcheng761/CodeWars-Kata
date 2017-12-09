using System;

public class Kata
{
  public static int signs(string text, string pattern)
  {
      // Loop through all instances of the string 'text'.
      int count = 0;
      int i = 0;
      while ((i = text.IndexOf(pattern, i)) != -1)
      {
          i += pattern.Length;
          count++;
      }
      return count;
  }

  public static int GCD(int a, int b) {
        int Remainder; 
        while( b != 0 ) {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        return a;
    }
  public static string MixedFraction(string s)
  {
    string sign;
    if (signs(s,"-")%2 == 0)
      sign = "";
    else 
      sign = "-";
    int num = Math.Abs(Convert.ToInt32(s.Substring(0,s.IndexOf("/"))));
    int den = Math.Abs(Convert.ToInt32(s.Substring(s.IndexOf("/")+1)));
    int whole = num/den; num = num%den;
    if (num == 0)
    {
      if (whole != 0)
      return sign + whole.ToString();
      else return whole.ToString();
    }
    
    int gcd = GCD(num,den);
    if (whole == 0)
      return sign + (num/gcd).ToString() + "/" + (den/gcd).ToString();
    return sign + whole.ToString() + " " + (num/gcd).ToString() + "/" + (den/gcd).ToString();
  }
}
