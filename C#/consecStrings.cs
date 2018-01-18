using System;
using System.Linq;
using System.Text;

public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            return "";
        int[] lengths = strarr.Select(s => s.Length).ToArray();
        int[] consecutiveslengths = new int[strarr.Length - k + 1];
        int sumOfLengths = 0;
        for (int i = 0; i < k; i++)
            sumOfLengths += lengths[i];
        consecutiveslengths[0] = sumOfLengths;
        for (int i = 1; i < consecutiveslengths.Length; i++)
        {
            sumOfLengths -= lengths[i - 1];
            sumOfLengths += lengths[i + k - 1];
            consecutiveslengths[i] = sumOfLengths;
        }
        int maxLength = consecutiveslengths.Max();
        int indexOfMaxLength = Array.IndexOf(consecutiveslengths, maxLength);
        StringBuilder result = new StringBuilder();
        int n = indexOfMaxLength + k;
        for (int i = indexOfMaxLength; i < n; i++)
            result.Append(strarr[i]);
        return result.ToString();
    }
}
