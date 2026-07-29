#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
 vector<double> temps;
 double input;

 cout << "Input temperature: ";
 while (cin >> input)
  temps.push_back(input); // 将获取的值存入 vector

 // 计算平均温度
 double sum = 0;
 for (int i = 0; i < temps.size(); ++i)
  sum += temps[i];

 cout << "Average temperature is: " << sum / temps.size() << endl;

 // 计算中职温度
 double median = 0.0;
 sort(temps.begin(), temps.end()); // 对 temps 排序
 if (temps.size() % 2 == 1)
  median = temps[temps.size() / 2];
 else
  median = (temps[temps.size() / 2] + temps[temps.size() / 2 - 1]) / 2;

 cout << "Median temperature: " << median << endl;

 return 0;
}