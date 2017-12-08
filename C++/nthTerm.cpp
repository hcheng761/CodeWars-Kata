#include <math.h>

std::string seriesSum(int n)
{
    int div = 1;
    double sum = 0.00;
    for (int i = 0; i < n; i++)
    {
      if (i == 0) {
        sum += 1;
      }
      else {
          div+=3;
          sum += (1/(double)div);
        }
    }
    return std::to_string(round(sum*100)/100).substr(0,4);
}
