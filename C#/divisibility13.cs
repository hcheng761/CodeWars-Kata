using System;

public class Thirteen {
    public static long Thirt(long n) {
        long temp = n;
        long result = 0;
        while(temp != result)
        {
          int digits = temp.ToString().Length;
          string str = temp.ToString();
          for (int i = 0; i < digits; i++)
          {
            switch(i%6)
            {
                case 0:  
                  result += ((long)Char.GetNumericValue(str[digits-i-1])*1);
                  continue;
                case 1:
                  result += (long)((int)Char.GetNumericValue(str[digits-i-1])*10);
                  continue;
                case 2:
                  result += (long)((int)Char.GetNumericValue(str[digits-i-1])*9);
                  continue;
                case 3:
                  result += (long)((int)Char.GetNumericValue(str[digits-i-1])*12);
                  continue;
                case 4:
                  result += (long)((int)Char.GetNumericValue(str[digits-i-1])*3);
                  continue;
                case 5:
                  result += (long)((int)Char.GetNumericValue(str[digits-i-1])*4);
                  continue;
              }
          }
          if (result != temp)
          {
            temp = result;
            result = 0;
            continue;
          }
          else
            return result;
        }
        return result;
    }
}