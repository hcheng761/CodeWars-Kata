import java.lang.StringBuilder;
class Solution{
  static String toCamelCase(String s){
    StringBuilder build = new StringBuilder();
    for (int i = 0; i < s.length(); i++)
    {
      if (s.charAt(i) == '-' || s.charAt(i) == '_')
      {
        build.append(Character.toString(s.charAt(i+1)).toUpperCase());
        i++;
      }
      else
        build.append(Character.toString(s.charAt(i)));
    }
    return build.toString();
  }
}
