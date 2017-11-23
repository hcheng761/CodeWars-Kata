using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    Console.WriteLine(word);
    List<int> list = new List<int>();
    for (int i = 0; i < word.Length; i++)
    {
      if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'y' ||
          word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U' || word[i] == 'Y')
            list.Add(i+1);
    }
    return list.ToArray();
  }
}
