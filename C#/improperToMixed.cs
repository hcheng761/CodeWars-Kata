namespace Fraction {
  using System;
  
  public class Convert
  {
    public string convertToMixedNumeral(string frac)
    {
      string num = frac.Substring(0,frac.IndexOf("/"));
      string den = frac.Substring(frac.IndexOf("/")+1, frac.Length - frac.IndexOf("/") - 1);
      int n, d;
      if (num[0] == '-')
        n = Int32.Parse(num.Substring(1,num.Length-1));
      else
        n = Int32.Parse(num.Substring(0,num.Length));
      d = Int32.Parse(den);
      
      if (n%d == 0)
      {
        if (num[0] == '-')
          return "-" + (n/d).ToString();
        else
          return (n/d).ToString();
      }
      else
      {
        if (num[0] == '-')
        {
          if (d > n)
            return num + "/" + den;
          else
            return "-" + (n/d).ToString() + " " + (n%d).ToString() + "/" + d.ToString();
        }
        else if (num[0] != '-')
        {
          if (d > n)
            return num + "/" + den;
          else
            return (n/d).ToString() + " "+ (n%d).ToString() + "/" + d.ToString(); 
        }
      }
      return "";
    }
  }
}
