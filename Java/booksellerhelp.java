import java.util.*;

public class StockList { 
	
  // 1st parameter is the stocklist (L in example), 
	// 2nd parameter is list of categories (M in example)
	public static String stockSummary(String[] lstOfArt, String[] lstOf1stLetter) {
		// your code here
    String format = "";
    
    if (lstOfArt.length == 0 || lstOf1stLetter.length == 0)
      return "";
    
    for (int i = 0; i < lstOf1stLetter.length; i++)
    {
      int total = 0;
      for (int j = 0; j < lstOfArt.length; j++)
        if (lstOf1stLetter[i].equals(Character.toString(lstOfArt[j].charAt(0))))
          total += Integer.valueOf(lstOfArt[j].replaceAll("[^0-9]", ""));
      format += "(" + lstOf1stLetter[i] + " : " + Integer.toString(total) + ")";
      if (i != lstOf1stLetter.length - 1)
        format += " - ";
    }
    
    if (Integer.valueOf(format.replaceAll("[^0-9]", "")) == 0)
      return "";
		return format;
	}
}
