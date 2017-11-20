public class Dinglemouse {
  public static String whatTimeIsIt(final double angle) {
    StringBuilder sb = new StringBuilder();
    System.out.println(angle);
    if (angle/30 < 10)
      if (angle/30 < 1)
        sb.append("12.0");
      else
        sb.append("0" + Double.toString((Math.floor(angle/30))));
    else
      sb.append(Double.toString(Math.floor(angle/30)));
    String hour = sb.toString().substring(0,sb.length()-2);
    
    sb.setLength(0);
    Double m = (angle % 30)*2;
    if (m < 10)
      sb.append("0" + Double.toString(m));
    else
      sb.append(Double.toString(m));
    String min = sb.toString().substring(0,2);
    
    return hour + ":" + min;
  }
}
