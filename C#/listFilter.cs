using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      List<int>list = new List<int>();
      for (int i = 0; i < listOfItems.Count; i++)
      {
        if (listOfItems[i].GetType() == typeof(int))
          list.Add((int)listOfItems[i]);
      }
      return list;
   }
}
