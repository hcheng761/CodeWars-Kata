public class Sequence {

  public static long getScore(long n) {
    // do your magic here
    long ans = 0;
    for (int i = 0; i <= n; i++)
      ans += 50*i;
    return ans;
  }
}
