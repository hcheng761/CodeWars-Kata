public class Kata {
    public static int findShort(String s) {
        String[] words = s.split(" ");
        int st = words[0].length();
        for (String temp : words)
          if (temp.length() < st)
            st = temp.length();
        return st;
    }
}
