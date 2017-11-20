#include <string>
using namespace std;

class SalesmanTravel
{
  static vector<string>addr;
  static vector<string>num;
  public:
    static string travel(const string& orgr, string zipcode);
    static void eval(int pos, const string& orgr);
};

vector <string>SalesmanTravel::addr;
vector <string>SalesmanTravel::num;

void SalesmanTravel::eval(int pos, const string& orgr)
{
  for (int i = pos; i >= 0; i--)
  {
    if (i == 0 || orgr[i-1] == ',')
    {
      string s = "";
      while(orgr[i] != ' ')
      {
        s += orgr[i];
        i++;
      }
      num.push_back(s);
      addr.push_back(orgr.substr(i+1,pos-i-2));
      return;
    }
  }
}

string SalesmanTravel::travel(const string& orgr, string zipcode)
{
  if (zipcode.length() < 8 || orgr.find(zipcode) == string::npos)
    return zipcode + ":/";
  
  string ret = "";
  size_t pos = orgr.find(zipcode, 0);
  while(pos != string::npos)
  {
      eval(pos,orgr);
      pos = orgr.find(zipcode,pos+1);
  }
  ret += zipcode + ':';
  for (int i = 0; i < addr.size(); i++)
  {
    cout << addr[i] << endl;
    if (i != addr.size()-1)
      ret += addr[i] + ',';
    else ret += addr[i] + '/';
  }
  for (int i = 0; i < num.size(); i++)
  {
    cout << num[i] << endl;
    if (i != num.size()-1)
      ret += num[i] + ',';
    else ret += num[i];
  }
  addr.clear();
  num.clear();
  return ret;
}
