class Accumul
{
public:
    static std::string accum(const std::string &s)
    {
      std::string out;
      for (int i = 0; i < s.length(); i++)
      {
        out+=toupper(s[i]);
        for (int j = 0; j < i; j++)
          out+=tolower(s[i]);
        out+="-";
      }
      return out.substr(0,out.length()-1);
    }
};
