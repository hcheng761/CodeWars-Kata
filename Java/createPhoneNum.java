import java.util.Arrays;

public class Kata {
  public static String createPhoneNumber(int[] numbers) {
    StringBuilder builder = new StringBuilder();
    for (int i : numbers)
      builder.append(i);
    String str = builder.toString();
    return "(" + str.substring(0, 3) + ") " + str.substring(3, 6) + "-" + str.substring(6, str.length());
  }
}
