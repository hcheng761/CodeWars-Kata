using System;
using System.Collections.Generic;
namespace Solution
{
  class Kata
    {
      public static int countInt(int c, ref int[] len) {
        int ret = 0;
        for (int i = 0; i < len.Length; i++) {
          if (len[i] == c)
            ret++;
        } return ret;
      }
      public static int find_it(int[] seq) 
      {
        List<int> checkInt = new List<int>();
        for (int i = 0; i < seq.Length; i++)
        {
          if (!checkInt.Contains(seq[i]))
          {
            checkInt.Add(seq[i]);
            if (countInt(seq[i],ref seq)%2 != 0)
              return seq[i];
          }
        }
        return 0;
      }
    }
}