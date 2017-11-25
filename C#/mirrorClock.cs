using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            int min = Int32.Parse(timeInMirror.Substring(timeInMirror.IndexOf(":")+1, 2));
            int hour = Int32.Parse(timeInMirror.Substring(0, 2));
            StringBuilder sb = new StringBuilder();
            int newMin = 0, newHour = 0;
            if (min == 0 || min == 60)
              newMin = 0;
            else
              newMin = 60-min;

            if (hour == 12 && min != 0)
              newHour = 11;
            else if ((hour == 11 && min != 0) || (hour == 12 && min == 0))
              newHour = 12;
            else {
              if (min != 0)
                newHour = 11-hour;
              else
                newHour = 12-hour;
            }
            
            if (newHour < 10)
              sb.Append("0" + newHour.ToString() + ":");
            else
              sb.Append(newHour.ToString() + ":");
            if (newMin < 10)
              sb.Append("0" + newMin.ToString());
            else
              sb.Append(newMin.ToString());
            return sb.ToString();
        }
    }
