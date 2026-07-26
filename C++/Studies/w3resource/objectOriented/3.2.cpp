#include <iostream>
#include <string>

class Person
{
private:
 std::string name;
 int age;
 std::string country;

public:
 Person(std::string name, int age, std::string country) : name(name), age(age), country(country)
 {
  if (age <= 0)
   std::cerr << "请重新输入年龄";
 }

 void setName(const std::string &n)
 {
  name = n;
 }

 void setAge(int a)
 {
  age = a;
 }

 void setCountry(const std::string &c)
 {
  country = c;
 }

 const std::string &getName()
 {
  return name;
 }

 int getAge()
 {
  return age;
 }

 const std::string &getCountry()
 {
  return country;
 }

 void getChar()
 {
 }

 void printInfo()
 {
  std::cout << "Name�� " << name << '\n'
            << "Age�� " << age << '\n'
            << "Country�� " << country << std::endl;
 }
};

int main()
{
 std::string name, country;
 int age;

std::cout << "请输入姓名，年龄，国籍，用空格分开\n";
 std::cin >> name >> age >> country;

 Person p(name, age, country);
 p.setName(name);
 p.setAge(age);
 p.setCountry(country);

 // ʹ�� getter ������ӡ��Ϣ
 p.printInfo();

 return 0;
}