std::string nextLetter(std::string str)
{
    for (int i = 0; i < str.length(); i++)
    {
      if (str[i] > 64 && str[i] < 91)
      {
        if (str[i] == 'Z')
          str[i] = 'A';
        else
          str[i]++;
      }
      else if (str[i] > 96 && str[i] < 123)
      {
        if (str[i] == 'z')
          str[i] = 'a';
        else
          str[i]++;
      }
    }
    return str;
}
