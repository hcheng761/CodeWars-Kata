std::string twoSort(std::vector<std::string> s)
{
    std::sort (s.begin(), s.begin()+s.size());
    std::vector<char>v(s[0].begin(), s[0].end());
    
    std::string val;
    for (int i = 0; i < v.size(); i++)
    {
      val += v[i];
      val += "***";
    }
    return val.substr(0,val.length()-3);
}
