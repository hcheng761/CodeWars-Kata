using System;
using System.Collections;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    ArrayList list = new ArrayList();
    ArrayList pos = new ArrayList();
    for(int i = 0; i < array.Length; i++)
      if (array[i]%2 != 0)
      {
        list.Add(array[i]);
        pos.Add(i);
      }
    list.Sort();
    for (int i = 0; i < list.Count; i++)
      array[(int)pos[i]] = (int)list[i];
    return array;
  }
}
