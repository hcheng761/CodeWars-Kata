using System;

public class Kata 
{
  public static int GetNumber(string str) 
  {
    string temp = str.Substring(0,5);
    for (int i = 1; i < str.Length - 4; i++)
      if ((str[i]-'0') >= (temp[0]-'0'))
        if (Int32.Parse(str.Substring(i,5)) > Int32.Parse(temp))
          temp = str.Substring(i,5);
    return Int32.Parse(temp);
  }
}
