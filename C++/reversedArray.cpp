std::vector<int> digitize(unsigned long n) 
{        
  std::string s = std::to_string(n);
  std::vector<int>v;
  for (int i = s.length() - 1; i >= 0; i--)
  {
    v.push_back(s[i] - '0');
  }
  return v;
}
