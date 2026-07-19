// read some temperatures into a vector

#include "std_lib_facilities.h"

int main()
{
 vector<double> temps;           // temperatures
 for (double temp; cin >> temp;) // 读取 temperature
 {
  temps.push_back(temp); // 将 temp 放入 temps 向量中

  // 后续步骤
 }
}