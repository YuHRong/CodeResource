// Write a C++ program to format the output.

#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
 cout << "\n\n Formatting the output :\n"; // Outputting a message to indicate formatted output
 cout << "----------------------------\n"; // Outputting a separator line

 // 用 pi 初始化 双精度浮点数
 double pi = 3.14159265;

 // 设置小数点为 4
 cout << fixed << setprecision(4);

 // 用四位小数显示 pi
 cout << "The value of pi : " << pi << endl;

 // 显示小数点后宽度为 8 的 pi
 cout << "The value of pi 4 decimal place of total width 8   : |" << setw(8) << pi << "|" << endl;

 cout << " The value of pi 4 decimal place of total width 10  : |" << setw(10) << pi << "|" << endl; // Displaying 'pi' with 4 decimal places and a width of 10

 cout << setfill('-');                                                                               // Setting the fill character to '-'
 cout << " The value of pi 4 decimal place of total width 8   : |" << setw(8) << pi << "|" << endl;  // Displaying 'pi' with 4 decimal places and a width of 8, filled with '-'
 cout << " The value of pi 4 decimal place of total width 10  : |" << setw(10) << pi << "|" << endl; // Displaying 'pi' with 4 decimal places and a width of 10, filled with '-'

 cout << scientific;                                                  // Setting the output format to scientific notation
 cout << " The value of pi in scientific format is : " << pi << endl; // Displaying 'pi' in scientific notation

 bool done = false;                              // Initializing a boolean variable 'done' with the value false
 cout << " Status in number : " << done << endl; // Displaying the boolean variable 'done' as a number (0 for false, 1 for true)

 cout << boolalpha;                                // Setting the output format to display true or false as words
 cout << " Status in alphabet : " << done << endl; // Displaying the boolean variable 'done' as true or false

 cout << endl; // Outputting a blank line for better readability

 return 0;
}