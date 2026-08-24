// Write a C++ program to show the manipulation of a string.

#include <iostream>
#include <string>

int main()
{
 std::string str{"welcome, w3resource"};
 int subStart{3}, subStop{4};
 int repStart{3}, repStop{4};

 std::cout << "\nShow the manipulation of a string:\n";
 std::cout << "-------------------------------------\n\n";

 std::cout << "The string:: " << str << '\n';

 std::cout << "The length of the string:: ";
 std::cout << str.size() << '\n';
 // 或者
 // std::cout << str.length() << '\n';

 std::cout << "The char at index 1 of the string:: ";
 std::cout << str.at(1) << '\n';

 std::cout << " The char at index 1 of the string [using array ]:: ";
 std::cout << str[1] << '\n';

 std::cout << "Is the string empty:: ";
 std::cout << str.empty() << '\n';

 std::cout << "Retrieve the sub-string from " << subStart << "rd position for " << subStop << " characters::";
 std::cout << str.substr(subStart, subStop) << '\n';

 std::cout << "The sub-string replace by \'went\':: ";
 std::cout << str.replace(repStart, repStop, "went") << '\n';

 std::cout << "Append a string\'end\' at last of the string:: ";
 std::cout << str.append(" end") << '\n';

 std::cout << "Append a string \'end\' at last of the string using operator:: ";
 std::cout << str + " end" << '\n';

 std::cout << "The string \'insert\' inserting at " << subStart << "rd position of the string:: ";
 std::cout << str.insert(3, " insert ") << '\n';

 std::string str2{};
 str2 = str;

 std::cout << "The new string is:: ";
 std::cout << str2 << '\n';

 std::cout << "Input a sentence:: ";
 std::getline(std::cin >> std::ws, str);

 std::cout << str << '\n';

 return 0;
}