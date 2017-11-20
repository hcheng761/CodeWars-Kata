public class FindOutlier{
  static int find(int[] integers){

  int evens=0, odds=0;
  for (int i = 0; i < 3; i++)
  {
      if (Math.abs(integers[i])%2 == 0)
        evens++;
      else
        odds++;
  }
  if (evens < odds)
      for (int i = 0; i >= 0; i++)
      {
          if (Math.abs(integers[i])%2 == 0)
            return integers[i];
      }
  else
      for (int i = 0; i >= 0; i++)
      {
          if (Math.abs(integers[i])%2 == 1)
            return integers[i];
      }
  return 0;
}}
