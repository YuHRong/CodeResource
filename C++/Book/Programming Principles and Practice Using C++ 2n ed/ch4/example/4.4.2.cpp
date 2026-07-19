// compute mean and median temperatures

#include "std_lib_facilities.h"

int main()
{
 vector<double> temps; // temperatures

 for (double temp; cin >> temp;) // 读取 temperatures
 {
  temps.push_back(temp); // 将 temp 添加到 vector 中

  // 计算平均温度
  double sum = 0;
  for (int x : temps)
   sum += x;

  cout << "Average temperature: " << sum / temps.size() << '\n';

  // compute median temperature:
  sort(temps);
  cout << "Median temperature: " << temps[temps.size() / 2] << '\n';
 }

 return 0;
}