import java.util.*;
import java.lang.Math;

public class DigPow {
	
	public static long digPow(int n, int p) {
  
    int length = String.valueOf(n).length();
    int total = 0;
    for (int i = 0; i < length; i++)
      total += (int)Math.pow((n/(int)Math.pow(10,i)) % 10, length + p - i - 1);
    if (total % n == 0) return total/n;
    else return -1;
	}
}
