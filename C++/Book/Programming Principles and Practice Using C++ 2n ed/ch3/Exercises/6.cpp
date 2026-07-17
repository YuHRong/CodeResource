// Write a program that prompts the user to enter three integer values, and then outputs the values in numerical sequence separated by commas. So, if the user enters the values 10 4 6, the output should be 4, 6, 10. If two values are the same, they should just be ordered together. So, the input 4 5 4 should give 4, 4, 5.

#include <iostream>

using namespace std;

int main()
{
 int n1, n2, n3;

 cout << "Input three integer, separated by spaces\n";
 cin >> n1 >> n2 >> n3;

 if (n1 <= n2 && n2 <= n3)
 {
  cout << n1 << ", " << n2 << ", " << n3 << endl;
 }
 else if (n2 <= n1 && n1 <= n3)
 {
  cout << n2 << ", " << n1 << ", " << n3 << endl;
 }
 else if (n3 <= n2 && n2 <= n1)
 {
  cout << n3 << ", " << n2 << ", " << n1 << endl;
 }
 else if (n1 <= n3 && n3 <= n2)
 {
  cout << n1 << ", " << n3 << ", " << n2 << endl;
 }
 else if (n2 <= n3 && n3 <= n1)
 {
  cout << n2 << ", " << n3 << ", " << n1 << endl;
 }
 else if (n3 <= n1 && n1 <= n2)
 {
  cout << n3 << ", " << n1 << ", " << n2 << endl;
 }

 return 0;
}