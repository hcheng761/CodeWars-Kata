namespace myjinxin
{
  public class Kata
  {
    public bool PrimeString(string s)
    {
      if ((s + s).IndexOf(s,1) == s.Length)
        return true;
      return false;
    }
  }
}
