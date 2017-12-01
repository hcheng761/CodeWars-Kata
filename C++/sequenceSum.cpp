int sequenceSum(int start, int end, int step)
{
  if (start > end)
    return 0;
  int total = 0;
  while (start <= end) {
    total += start;
    start+=step;
  }
  return total;
}
