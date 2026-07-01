/* #include<iostream>

using namespace std;

int main(){
 char str[] = "Hello World!";

 cout << "str 变量的值是： " << str << endl;

 return 0;
}  */

/* #include <iostream>

using namespace std;

int main()
{
 char name[50];
 cout << "What's your name?" << endl;
 cin >> name;
 cout << "welcome " << name << endl;

 return 0;
} */

/* #include <iostream>

using namespace std;

int main()
{
 char str[] = "Unable to read....";

 cerr << "Error message : " << str << endl;

 return 0;
} */

#include <iostream>

using namespace std;

int main()
{
 char str[] = "Unable to read....";
 clog << "Error message : " << str << endl;
 return 0;
}