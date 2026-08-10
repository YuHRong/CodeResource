// Write a C++ program to create a Car class that validates the year of manufacture and overloads the equality operator to compare two cars.

#include <iostream>
#include <string>
using namespace std;

class Car
{
private: // 私有成员
 string company;
 string model;
 int year;

public: // 共有成员
 // 构造函数
 Car(string comp, string mod, int y = 0) : company(comp), model(mod), year(y)
 {
  if (year < 1886 || year > 2026)
  {
   cout << "Time error." << endl;
   year = 0;
  }
 }

 // setter getter 成员函数
 // 相等运算符重在
 bool operator==(const Car &obj) const
 {
  return (company == obj.company && model == obj.model && year == obj.year);
 }

 void display() const
 {
  cout << "Company: " << company << ", model: " << model << ", year: " << year << endl;
 }
};

int main()
{
 Car c1("Audi", "A6-L", 2016);
 Car c2("Audi", "A6", 2014);
 Car c3("Audi", "A6-L", 2016);
 Car c4("Audi", "Q-7", 2028);

 c1.display();
 c2.display();
 c3.display();
 c4.display();

 if (c1 == c2)
  cout << "Car1 is equal Car2"  << endl;
 else
  cout << "Car1 is not equal Car2" << endl;

 if (c1 == c3)
  cout << "Car1 is equal Car3" << endl;
 else
  cout << "Car1 is not equal Car3" << endl;

 if (c2 == c3)
  cout << "Car2 is equal Car3" << endl;
 else
  cout << "Car2 is not equal Car3" << endl;

 return 0;
}