namespace DayCount {
  using System;
  
  public class Day
  {
    public string countDays(DateTime d){
      var input = d.Date;
      var today = DateTime.Today.Date;
    
      if (input < today)
      {
        return "The day is in the past!";
      }
      else if (input == today)
      {
        return "Today is the day!";
      }
      else 
      {
        var days = (input - today).TotalDays - 1;
        return $"{days} days";
      }
    }
  }
  
}
