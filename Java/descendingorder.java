import java.util.*;

public class DescendingOrder {
  public static int sortDesc(final int num) {
    char[] chars = ("" + num).toCharArray();
    Arrays.sort(chars);
    
    String reversed = new StringBuilder(new String(chars)).reverse().toString();
    int result = Integer.parseInt(reversed);
    
    return result;
  }
}
