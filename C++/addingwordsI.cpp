#include <iostream>
#include <string>
using namespace std;

class Arith{
  private:
    string sNum;
    int num;
    const string str[21] = {"zero", "one", "two", "three", "four", "five", "six", "seven",
                           "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                           "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};
  public:  
    Arith(string s)
    {
      num = findInt(s);
      sNum = s;
    }
    string arith(int arg);
    int findInt(string arg);
    string add(string s);
};

string Arith::arith(int arg)
{
  return str[arg];
}

int Arith::findInt(string arg)
{
  for (int i = 0; i < 20; i++)
    if (arg == str[i])
      return i;
}

string Arith::add(string s)
{
  int sum = findInt(s) + num;
  return arith(sum);
}
