std::string get_middle(std::string input) 
{
  if (input.length()%2 != 0)
  {
    return input.substr(input.length()/2,1);
  }
  else
    return input.substr(input.length()/2-1,2);
}
