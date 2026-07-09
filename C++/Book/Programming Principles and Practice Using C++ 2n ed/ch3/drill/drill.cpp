// Drill
// 1. This drill is to write a program that produces a simple form letter based on user input.

#include "std_lib_facilities.h"

using namespace std;

int main()
{
 cout << "Please enter your first name (followed by 'enter'):\n";
 string writer_name;
 cin >> writer_name;
 cout << "Hello, " << writer_name << "!\n";

 // Enter the name of the person you want to write to”，并将输出修改为“Dear first_name，”。
 cout << "Enter the name of the person you want to write to\n";
 string first_name; // first_name 是字符串变量
 cin >> first_name; // 将字符读入 first_name

 // 2. Add an introductory line or two, like “How are you? I am fine. I miss you.” Be sure to indent the first line. Add a few more lines of your choosing — it’s your letter.
 cout << "Dear " << first_name << ",\n";
 cout << "  How are you?\n"
      << " I am fine.\n"
      << " I miss you.\n";

 // 3. Now prompt the user for the name of another friend, and store it in friend_name. Add a
 cout << "enter your second friend name.\n";

 string friend_name;
 cin >> friend_name;
 cout << "Have you seen " << friend_name << " lately?\n";

 // 4. Declare a char variable called friend_sex and initialize its value to 0. Prompt the user to
 // enter an m if the friend is male and an f if the friend is female. Assign the value entered to
 cout << "Enter an m if the friend is male and an f if the friend is female.\n";
 char friend_sex = 0;
 cin >> friend_sex;

 // If the friend is male, write “If you see friend_name please ask him to call me.”
 if (friend_sex == 'm' || friend_sex == 'M')
  cout << "If you see " << friend_name << " please ask him to call me.\n";
 // If the friend is female, write “If you see friend_name please ask her to call me.”
 if (friend_sex == 'f' || friend_sex == 'F')
  cout << "If you see " << friend_name << " please ask her to call me.\n";

 // 5. Prompt the user to enter the age of the recipient and assign it to an int variable age. Have your program write “I hear you just had a birthday and you are age years old.” If age is 0 or less or 110 or more, call simple_error("you're kidding!") using simple_error() from std_lib_facilities.h.
 cout << "Please enter the age of the recipient.\n";
 int age;
 cin >> age;

 if (age <= 0 || age >= 110)
  simple_error("you're kidding");

 cout << "I hear you just had a birthday and you are " << age << " years old.\n";

 // 6. Add this to your letter:
 // If your friend is under 12, write “Next year you will be age+1.”
 if (age < 12)
  cout << "Next year you will be " << age + 1 << "." << '\n';

 // If your friend is 17, write “Next year you will be able to vote.”
 if (age == 17)
  cout << "Next year you will be able to vote.\n";

 // If your friend is over 70, write “I hope you are enjoying retirement.”
 if (age >= 70)
  cout << "I hope you are enjoying retirement.\n";

 // 7. Add “Yours sincerely,” followed by two blank lines for a signature, followed by your name.
 cout << "\nYours sincerely,\n\n";
 cout << "\n";
 cout << "  "
      << writer_name << '\n'
      << '\n';

 return 0;
}