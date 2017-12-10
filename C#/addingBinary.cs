using System;
using System.Text;

public class BinaryNumbers
{
  public static string Add(string a, string b)
  {
    if (a.Length > b.Length)
    { 
      StringBuilder asb = new StringBuilder();
      for (int i = 0; i < a.Length-b.Length; i++)
        asb.Append("0");
      asb.Append(b); b = asb.ToString();
    }
    else if (b.Length > a.Length)
    {
      StringBuilder bsb = new StringBuilder();
      for (int i = 0; i < b.Length-a.Length; i++)
        bsb.Append("0");
      bsb.Append(a); a = bsb.ToString();
    }    

    StringBuilder sb = new StringBuilder();
    int carryOver = 0;
    for (int i = a.Length-1; i >= 0; i--)
    {
      if (a[i] == '1' && b[i] == '1')
      {
        if (carryOver == 0)
        {
          sb.Insert(0, "0");
          carryOver = 1;
        }
        else if (carryOver == 1)
          sb.Insert(0, "1");
      }
      else if (a[i] == '0' && b[i] == '0')
      {
        if (carryOver == 1)
        {
          carryOver = 0;
          sb.Insert(0, "1");
        }
        else
          sb.Insert(0, "0");
      }
      else if ((a[i] == '1' && b[i] == '0') || (b[i] == '1' && a[i] == '0'))
      {
        if (carryOver == 1)
          sb.Insert(0, "0");
        else
          sb.Insert(0,"1");
      }  
    }
    if (carryOver == 1)
      sb.Insert(0,"1");
    sb.Append("C");
    
    while (sb[0] == '0')
      sb.Remove(0,1);

    sb.Length--;
    
    if (sb.Length == 0)
      return "0";
      
    return sb.ToString();
  }
}
