using namespace std;

class SequenceSum{
  int count;
  public:
  SequenceSum (int);
  string showSequence();
  
};

string SequenceSum::showSequence(){
    if (count == 0)
      return "0=0";
    else if (count < 0)
      return std::to_string(count) + "<0";
    int sum = 0;
    string s;
    for (int i = 0; i <= count; i++)
    {
      sum+=i;
      s+=std::to_string(i);
      s+="+";
    }
    return s.substr(0,s.length()-1) + " = " + std::to_string(sum);
}

SequenceSum::SequenceSum (int c) {
  count = c;
}
