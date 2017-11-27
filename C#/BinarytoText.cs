using System;
using System.Collections.Generic;
using System.Text;

public static class Kata
{
	public static string BinaryToString(string binary)
	{
      var text = new StringBuilder();
      List<int>split = new List<int>();
      
      for (int i = 0; i < binary.Length; i+=8)
        split.Add(Convert.ToInt32(binary.Substring(i,8),2));
      foreach (var i in split)
        text.Append(((char)i).ToString());
      return text.ToString();
	}
}
