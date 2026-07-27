// 继承实力
#include <iostream>

class Animal
{
public:
 void speak()
 {
  std::cout << "Animal speaks!" << std::endl;
 }
};

class Dog : public Animal // Dog 继承 Animal
{
public:
 void bark()
 {
  std::cout << "Dog barks!" << std::endl;
 }
};

int main()
{
 Dog dog;

 dog.speak(); // 继承自 Animal
 dog.bark();  // Dog 自有的函数

 return 0;
}