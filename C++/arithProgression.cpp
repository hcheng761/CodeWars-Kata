#include <string>

std::string arithmeticSequenceElements(int a, int r, int n)
{
  std::string s = std::to_string(a) + ", ";
  int cnt = a;
  for (int i = 0; i < n-1; i++)
  {  
    cnt+=r;
    s+=std::to_string(cnt) + ", ";
  }
  return s.substr(0, s.length()-2);
}
