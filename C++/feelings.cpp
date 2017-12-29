std::string countFeelings(std::string s, std::vector<std::string> arr)
{
  int feelings = 0;
  std::sort(s.begin(), s.end());
  for (int i = 0; i < arr.size(); i++)
  {
    sort(arr[i].begin(), arr[i].end());
    std::string sTemp = s;
    int temp = 0;
    for (int j = 0; j < arr[i].length(); j++)
    {
      temp = sTemp.find(arr[i][j]);
      if (temp == std::string::npos) 
        break;
      if (j == arr[i].size() - 1)
        feelings++;
      sTemp = sTemp.substr(temp + 1);std::cout << sTemp << std::endl;
      
    }
  }
  if (feelings == 1)
    return "1 feeling.";
  else
    return std::to_string(feelings) + " feelings.";
}
