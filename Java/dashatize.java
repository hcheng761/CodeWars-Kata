public class Solution {
    public static String dashatize(int num) {
      int len = Integer.toString(num).length();
      String str = Integer.toString(num);
      StringBuilder sb = new StringBuilder();
      
      for (int i = 0; i < len; i++)
      {
        if (Character.getNumericValue(str.charAt(i))%2 != 0)
        {
          if (i == 0)
            sb.append(str.charAt(i) + "-");
          else if (i == len - 1)
            sb.append("-" + str.charAt(i));
          else
            sb.append("-" + str.charAt(i) + "-");
        }
        else
          sb.append(str.charAt(i));
      }   
      
      for (int i = 0; i < sb.length()-1; i++)
        if (sb.charAt(i) == '-' && sb.charAt(i+1) == '-')
        {
          sb.deleteCharAt(i);
          i = 0; 
        }
      while (sb.charAt(0) == '-')
        sb.deleteCharAt(0);
      return sb.toString();
    }
}