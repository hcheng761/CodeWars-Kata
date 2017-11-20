import java.util.Arrays;
public class Solution {

    public static int solveSuperMarketQueue(int[] customers, int n) {
      int[] checkout = new int[n];
      for(int i = 0; i < customers.length; i++)
      {
        checkout[0] += customers[i];
        Arrays.sort(checkout);
      }
      return checkout[n-1];
    }
    
}
