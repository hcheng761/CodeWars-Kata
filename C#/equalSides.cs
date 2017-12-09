using System;

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int[] right = new int[arr.Length];
    int lsum = 0, rsum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      rsum += arr[arr.Length-i-1];
      right[arr.Length-1-i] = rsum;
    }
    for (int i = 0; i < arr.Length; i++)
    {
      lsum += arr[i];
      if (lsum == right[i])
        return i;
    }
    return -1;
  }
}
