# C++ 类和对象

类用于指定对象的形式，是一种用户自定义的数据类型，它是一种封装了数据和函数的组合。类中的数据称为成员变量，函数称为成员函数。类可以被看作是一种模板，可以用来创建具有相同属性和行为的多个对象。

## 类定义

定义类需要使用关键字 `class`， 加类名称加上一对花括号（内含类的主题函数）。

定义一个类，本质上是定义一个数据类型的蓝图，它定义了类的对象包括了什么，以及可以在这个对象上执行哪些操作。

### 实力

定义一个 Box 类

```c++
class Box
{
 public:
 double length;     // 盒子的长度
 double breadth;    // 盒子的宽度
 double hight;    // 盒子的高度
};
```
关键字 `public` 确定了类成员的属性是公共的，可以在外部访问，也可以使用 `private`或`protected`。关键字申明为私有成员。

## 定义对象

类提供了对象的蓝图，所以基本上，对象是根据类来创建的。声明类的对象，就像声明基本类型的变量一样。下面的语句声明了类 Box 的两个对象：

```c++
Box Box1;           // 声明 Box1，类型为 Box
Box Box2;          // 声明 Box2，类型为 Box
```

对象 `Box1` 和 `Box2` 都有它们各自的数据成员。

## 访问数据成员

类的对象的公共数据成员可以使用直接成员访问运算符`.`来访问。

### 实力

```c++
#include <iostream>

using namespace std;

class Box
{
public:
 double length;  // 长度
 double breadth; // 宽度
 double height;  // 高度

 // 成员函数声明
 double get(void);

 void set(double len, double bre, double hei);
};

// 成员函数定义
double Box::get(void)
{
 return length * breadth * height;
}

void Box::set(double len, double bre, double hei)
{

 length = len;
 breadth = bre;
 height = hei;
}

int main()
{
 Box Box1;            // 声明 Box1，类型为 Box
 Box Box2;            // 声明 Box2，类型为 Box
 Box Box3;            // 声明 Box3，类型为 Box
 double volume = 0.0; // 用于存储体积

 // box 1 详述
 Box1.height = 5.0;
 Box1.length = 6.0;
 Box1.breadth = 7.0;

 // box 2 详述
 Box2.height = 10.0;
 Box2.length = 12.0;
 Box2.breadth = 13.0;

 // Box1 的体积
 volume = Box1.length * Box1.breadth * Box1.height;
 cout << "Box1 的体积是： " << volume << endl;

 // Box2 的体积
 volume = Box2.height * Box2.length * Box2.breadth;
 cout << "Box2 的体积是： " << volume << endl;

 // box 3 详述
 Box3.set(16.0, 8.0, 12.0);
 volume = Box3.get();
 cout << "Box3 的体积是： " << volume << endl;

 return 0;
}
```

上面实力输出为：

```c++
Box1 的体积是： 210
Box2 的体积是： 1560
Box3 的体积是： 1536
```

**注意**私有成员和受保护的成员不能使用成员访问符`.`来进行访问。

--------------------------------------------------
