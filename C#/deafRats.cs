using System;
using System.Linq;
public class Dinglemouse
{
  public static int CountDeafRats(string town)
  {
    town = town.Replace(" ","");
    int result = 0;
    int piper = town.IndexOf('P');
    for(int i = 0; i < piper - 1; i += 2){
      if(town[i] == 'O' && town[i + 1] == '~') result++;
    }
    
    for(int i = piper + 1; i < town.Length - 1;i += 2){
      if(town[i] == '~' && town[i + 1] == 'O') result++;
    }
    return result;
  }
}
