std::string is_sorted_and_how(std::vector<int> array)
{
    bool ascend = false;
    if (array[0] < array[1])
      ascend = true;
    for (int i = 1; i < array.size()-1; i++)
    {
      if (ascend == true)
        if (array[i] > array[i+1])
          return "no";
      if (ascend == false)
        if (array[i] < array[i+1])
          return "no";
    }
    if (ascend == true)
      return "yes, ascending";
    else
      return "yes, descending";
}
