int countLettersAndDigits(std::string input)
{
  std::cout << input << std::endl;
  int count = 0;
  for (int i = 0; i < input.length(); i++)
  {
    if (((int)input[i] > 64  && (int)input[i] < 91) || 
      ((int)input[i] > 96 && (int)input[i] < 123) || 
      ((int)input[i] > 47 && (int)input[i] < 58))
      count++;
 
  }
  return count;
}
