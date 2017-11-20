std::vector<int> sqrtApproximation(double number) {
  int cnt = 0;
  while(true)
  {
    if (number == (cnt*cnt))
      return std::vector<int>{cnt};
    else if (number < (cnt*cnt))
      return std::vector<int>{cnt-1,cnt};
    cnt++;
  }
}
