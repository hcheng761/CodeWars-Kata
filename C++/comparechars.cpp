#include <cctype>

using namespace std;

bool IsLetters(string input)
{
	for (int i = 0; i < input.size(); i++) {
		int uppercaseChar = toupper(input[i]); //Convert character to upper case version of character
		if (uppercaseChar < 'A' || uppercaseChar > 'Z') //If character is not A-Z
			return false;
	}
	return true;
}

bool compare(string s1, string s2)
{
    bool s1let = IsLetters(s1); bool s2let = IsLetters(s2);
    int s1val = 0, s2val = 0;
    for (int i = 0; i < s1.size(); i++) {
      if (s1 == "" || s1let == false)
        break;
      s1val += int(toupper(s1[i]));    
    }
    for (int i = 0; i < s2.size(); i++)  {
      if (s2 == "" || s2let == false)
        break;
      s2val += int(toupper(s2[i]));
    }
    return ( s1val == s2val ? true : false);
}
