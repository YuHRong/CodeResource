// Write a C++ program to create a class called Person that has private member variables for name, age and country. Implement member functions to set and get the values of these variables.

#include <iostream>
#include <string>

class Person
{
private:
 std::string name;
 int age;
 std::string country;

public:
 /*
    构造函数
   Person(std::string name, int age, std::string country)
       : name(name), age(age), country(country)
{ }
 */

 // Setter 函数用于获取私有对象
 void setName(const std::string &n)
 {          // 用于获取name的函数
  name = n; // 将提供的名称分配给“name”成员变量
 }

 void setAge(int a)
 {         // 用于获取 age 的函数
  age = a; // 将提供的年龄分配给“age”成员变量
 }

 void setCountry(const std::string &c)
 {             // 用于获取 country 函数
  country = c; // 将 country 分配给 country
 }

 std::string getName()
 {             // 用于检索名称的Getter函数
  return name; // 返回保存的name
 }

 int getAge()
 {            // 用于检索 age 的getAge函数
  return age; // 返回存储的 age
 }

 std::string getCountry()
 {                // 用于检索国家的Getter函数
  return country; // 返回保存的 country
 }
};

int main()
{
 // 创建 Person 对象
 Person person;

 // 使用setter函数设置人员的详细信息
 person.setName("Saveli Sujatha"); // 设置姓名
 person.setAge(25);                // 设置年龄
 person.setCountry("USA");         // 设置国家

 // 使用getter函数获取并显示该人的详细信息
 // 输出 name
 std::cout << "Name " << person.getName() << std::endl;
 // 打印年龄
 std::cout << "Age : " << person.getAge() << std::endl;
 // 打印国家
 std::cout << "Country : " << person.getCountry() << std::endl;

 return 0;
}