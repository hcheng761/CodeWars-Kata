using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    if (n < 0) 
      return false;
    int inc = 0;
    while(true)
    {
      if ((inc*inc) == n)
        return true;
      else if ((inc*inc) > n)
        return false;
      inc++;
    }
  }
}
