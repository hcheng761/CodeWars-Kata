using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    input = input.ToLower();
    
    if (input.IndexOf('x') == -1 && input.IndexOf('o') == -1)
      return true;
    Console.WriteLine(input.Count(x => x == 'o'));
    Console.WriteLine(input.Count(x => x == 'x'));
    
    if (input.Count(x => x == 'x') == input.Count(o => o == 'o'))
      return true;
    return false;
  }
} 
