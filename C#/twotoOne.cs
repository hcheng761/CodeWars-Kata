using System.Linq;
using System;

public class TwoToOne 
{ 
	public static string Longest (string s1, string s2) 
  {
      char[] s = String.Join("", String.Concat(s1,s2).Distinct()).ToCharArray();
      Array.Sort(s);
      return new string(s);
  }
}
