class Kata
{
public:
    std::vector<std::string> sortByLength(std::vector<std::string> array)
    {
      for (int i = 0; i < array.size(); i++)
      {
        int temp = i;
        for (int j = i; j < array.size(); j++)
        {
          if (array[j].length() < array[temp].length())
          {
            temp = j;
          }
        }  
        std::string s = array[temp];
        array[temp] = array[i];
        array[i] = s;
      }
      return array;
    }
};
