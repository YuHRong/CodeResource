/*显示消息*/

#include<iostream>       // 一个预处理程序

int main() {    // 函数头
 // 函数体开始
 using namespace std;    // 使定义可见
 cout << "Hello world!" << endl;      // 打印消息

 cout << "Comme up and C++ me some time."
  << endl;
 cout << "you won't regret it!" << endl;

 // 如果输出窗口运行后关闭
 // 添加以下代码：
 cout << "Press any key to continue." << endl;
 cin.get();

 return 0;     // 中止
}          // 函数体结束
