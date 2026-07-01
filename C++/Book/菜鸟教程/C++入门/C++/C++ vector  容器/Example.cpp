#include <iostream>
#include <vector>
#include <numeric>

using namespace std;

int main()
{
 vector<int> scores = {85, 90, 78, 92};
 scores.push_back(88);

 cout << "所有成绩： ";
 for (int score : scores)
 {
  cout << score << " ";
 }
 cout << endl;

 int total = std::accumulate(scores.begin(), scores.end(), 0);
 double average = total * 1.0 / scores.size();

 cout << "总成绩： " << total << endl;
 cout << "平均成绩： " << average << endl;
 scores.erase(scores.begin() + 2);

 cout << "删除后成绩： ";
 for (int score : scores)
 {
  cout << score << " ";
 }
 cout << endl;

 return 0;
}