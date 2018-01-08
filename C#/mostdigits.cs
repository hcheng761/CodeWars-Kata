using System;

public class Kata
{
  public static int GetDigits(int num)
  {
    return (int)Math.Floor(Math.Log10(num) + 1);
  }
  public static int FindLongest(int[] number)
  {
    int temp = 0; int dig = GetDigits(number[0]);
    for (int i = 1; i < number.Length; i++)
      if (number[i] > number[temp] && GetDigits(number[i]) > dig){
        temp = i;
        dig = GetDigits(number[temp]);
      }
    return number[temp];
  }
}
