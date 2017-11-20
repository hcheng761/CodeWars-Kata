import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Consecutives {
    
    public static List<Integer> sumConsecutives(List<Integer> s) {
        // your code
        List<Integer> newList = new ArrayList<Integer>();
        for (int i = 0; i < s.size(); i++)
        {
          int dist = 1;
          for (int j = i+1; j < s.size(); j++)  {
            if (s.get(j) != s.get(i)) break;
            i++;
            dist++;
          }
          newList.add(dist * s.get(i));
        }
        return newList;
    }

}
