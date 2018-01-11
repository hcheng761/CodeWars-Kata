using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int i = 0;
    foreach(var b in sheeps)
      if (b)
        i++;
    return i;
  }
}
