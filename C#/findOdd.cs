using System;

namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
      if (seq.Length == 1)
        return seq[0];
      Array.Sort(seq); 
      int count = 0, temp = seq[0];
      for (int i = 0; i < seq.Length; i++)
      {
        if (seq[i] == temp)
          count++;
        else
        {
          if (count%2 == 1)
            return temp;
          else
          {
            if (i == seq.Length - 1)
              return seq[i];
            else
            {
              temp = seq[i];
              count = 1;
            }
          }
        }
      }
      return temp;
    }
       
  }
}
