using System;
using System.Text;

public static class Kata
{
  public static string Likes(string[] name)
  {
    int len = name.Length;
    StringBuilder sb = new StringBuilder();
    if (len == 0)
    {
      return "no one likes this";
    }
    else if (len == 1)
    {
      return name[0] + " likes this";
    }
    else if (len == 2)
    {
      sb.Append(name[0]);
      sb.Append(" and ");
      sb.Append(name[1]);
      return sb.ToString() + " like this";
    }
    else if (len == 3)
    {
      sb.Append(name[0]);
      sb.Append(", ");
      sb.Append(name[1]);
      sb.Append(" and ");
      sb.Append(name[2]);
      return sb.ToString() + " like this";
    }
    
    else if (len > 3)
    {
      sb.Append(name[0]);
      sb.Append(", ");
      sb.Append(name[1]);
      sb.Append(" and ");
      sb.Append((len-2).ToString());
      sb.Append(" others like this");
      return sb.ToString();
    }
    throw new NotImplementedException();
  }
}
