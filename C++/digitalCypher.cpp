#include <string>
#include <string.h>

using namespace std;

class Kata
{
public:
    static vector<int> Encode(string str, int n)
    {
      vector<int>code(str.length());
      string key = to_string(n);
      int keyLen = key.length();
      
      for (int i = 0; i < str.length() - keyLen; i++)
        key += key[i];
      
      for (int i = 0; i < str.length(); i++)
        code[i] = (int(str[i])-96) + (key[i] - '0');
      return code;
    };
};
