using namespace std;

class Kata
{
public:
    vector<string> towerBuilder(int nFloors)
    {
        vector<string>tower(nFloors);
        for (int i = 0; i < nFloors; i++) {
          string s = "*";
          for (int j = 1; j < 2*(i+1)-1; j++)
            s += '*';
          for (int j = 1; j < nFloors-i; j++) {
            s = " " + s;
            s += " ";
          }          
          tower[i]=s;
        }
        return tower;
    }
};
