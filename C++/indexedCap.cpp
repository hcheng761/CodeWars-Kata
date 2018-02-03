std::string capitalize(std::string s, std::vector<int> idxs)
{   

    for (int i = 0; i < idxs.size(); i++)
    {
         std::cout << idxs[i] << std::endl;
         if (idxs[i] <= s.length())
         {
         char c = s[idxs[i]];
         s[idxs[i]] = toupper(c);
         }
    }
    std::cout  << std::endl;
    return s;
}
