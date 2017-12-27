int divisors(long long n)
{
  int count = 0;
  if (n == 1)
    return 1;
  for (int i = 1; i <= n/2; i++)
  {
    if (n % i == 0)
    {
      if ((n/i) == i)
        count++;
      else if ((n/i) > i)
        count+=2;
    }
  }
	return count;
}
