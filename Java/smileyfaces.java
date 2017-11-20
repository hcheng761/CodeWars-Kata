import java.util.*;

public class SmileFaces {
  
  public static int countSmileys(List<String> arr) {
      // Just Smile :)
      int smileys = 0;
      String smiley = "(:|;)+(~|-)?(\\)|D)$";
      for (int i = 0; i < arr.size(); i++)
        if (arr.get(i).matches(smiley) == true)
            smileys++;
      return smileys;
  }
}
