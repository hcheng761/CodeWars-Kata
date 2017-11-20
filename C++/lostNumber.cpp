#include <numeric>
using namespace std;

int findDeletedNumber(list<int> startingList, list<int> mixedList)
{
    int sum1 = std::accumulate(startingList.begin(), startingList.end(), 0);
    int sum2 = std::accumulate(mixedList.begin(), mixedList.end(), 0);
    return sum1 - sum2;
}
