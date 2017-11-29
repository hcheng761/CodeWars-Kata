using System;
using System.Collections.Generic;

public class Kata
{
  static private int hor = 0;
  static private int vert = 0;
  
  public static void evalDir(string dir)
  {
    if (dir == "N" || dir == "S") {
      if (dir == "N") vert++;
      else vert--;
    }
    else if (dir == "W" || dir == "E") {
      if (dir == "E") hor++;
      else hor--;
    }
    return;
  }
  public static string[] directions(string[] goal)
  {
    if (goal.Length == 0)
      return new string[0];
    
    List<string>list = new List<string>();
    for (int i = 0; i < goal.Length; i++)
      evalDir(goal[i]); 
      
    if (vert > 0)
      for (int i = 0; i < vert; i++)
        list.Add("N");
    else if (vert < 0)
      for (int i = 0; i > vert; i--)
        list.Add("S");
    
    if (hor > 0)
      for (int i = 0; i < hor; i++)
        list.Add("E");
    else
      for (int i = 0; i > hor; i--)
        list.Add("W");
    vert = 0; hor = 0;
    return list.ToArray();
  }
}
