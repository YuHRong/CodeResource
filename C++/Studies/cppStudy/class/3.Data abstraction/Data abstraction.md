## 什么是数据抽象

数据抽象是一种处理复杂性的方法，它通过隐藏实现细节并只暴露必要的接口来简化程序设计 。通过数据抽象，程序员可以专注于对象的功能，而不必关注其内部实现。

### 抽象的好处

- `简化复杂性`：仅提供必要的信息，隐藏不必要的细节。
- `增强代码的可维护性`：修改内部实现时无需更改外部接口。
- `提高代码的可重用性`：可以在不同的上下文中使用相同的抽象。
## c++ 中的数据抽象

在 C++ 中，数据抽象主要通过类（`Class`）实现。类将数据（属性）和操作这些数据的函数（方法）组合在一起，形成一个完整的抽象。

### 类的定义

类定义了对象的属性和行为。属性通常以数据成员的形式存在，而行为则以成员函数的形式存在。

```cpp


class Rectangle
{
private:
 /* data */
 int width, height; // 数据成员，属性

public:
 // 构造函数
 Rectangle(int w, int h) : width(w), height(h) {}

 // 成员函数、方法
 int area(){
  return width * height;     // 计算面积
 }
};
```

### 对象的创建

使用类定义的对象可以表达现实世界中的实体，通过对象与对象之间的交互来实现具体的功能。

```cpp
int main()
{
 Rectangle rect(10, 5); // 创建对象

 std::cout << "面积： " << rect.area() << std::endl; // 调用成员函数

 return 0;
}
```

### 访问控制

C++ 使用访问修饰符（`public`、 `protected` 和 `private`）来控制类成员的可见性，以实现数据的封装和抽象。

- `public`：：公有成员，外部可以访问。
- `private`：私有成员，仅在类内部可以访问，外部无法直接访问。
- `protected`：受保护成员，只有类本身和派生类可以访问。

```cpp
#include <iostream>

class BankAccount
{
private:
 /* data */
 double balance; // 私有数据成员
public:
 BankAccount(/* args */) : balance(0.0) {} // 构造函数

 // 公有接口
 void deposit(double amount)
 {
  balance += amount;
 }

 void withdraw(double amount)
 {
  if (amount <= balance)
  {
   balance -= amount;
  }
  else
   std::cout << "Insufficient funds!" << std::endl;
 }

 double getBalance() const
 {
  return balance; // 仅提供读取余额的接口
 }
};
```

## 抽象类与接口

### 抽象类

抽象类是指至少有一个纯虚函数的类。抽象类不能被实例化，只能作为基类被继承。它提供了一个接口，要求派生类实现特定的功能。

#### 纯虚函数

通过在函数声明后加`= 0`来定义纯虚函数。

```cpp
class Shape
{
public:
 /* data */
 virtual double area() = 0; // 纯虚函数
};
```

### 接口

在 C++ 中，接口通常是一个只包含纯虚函数的抽象类。派生类必须实现这些虚函数，才能创建实例。接口定义了行为，但不提供实现。

```cpp
#include <iostream>

class Shape
{
public:
 /* data */
 virtual double area() = 0; // 纯虚函数
 virtual void draw() = 0;   // 另一个纯虚函数
};

class Circle : public Shape
{
private:
 double radius;

public:
 Circle(double r) : radius(r) {}
 double area() override
 {
  return 3.14159 * radius * radius; // 计算面积
 }

 void draw() override
 {
  std::cout << "Drawing Circle" << std::endl; // 实现绘制
 }
};

class Square : public Shape
{
private:
 double side;

public:
 Square(double s) : side(s) {}

 double area() override
 {
  return side * side; // 实现面积计算
 }

 void draw() override
 {
  std::cout << "Drawing Square" << std::endl; // 实现绘制
 }
};
```

1. 抽象类 `Shape`
- `Shape`是一个抽象类，不能直接实例化。它定义了两个纯虚函数：
- `area()`：计算形状的面积。
- `draw()`：绘制形状。
- `纯虚函数`：通过在函数名后添加`= 0`，表示这是一个纯虚函数，要求所有派生类必须实现这些函数。这样，`Shape`类提供了一个接口，定义了所有形状必须具备的功能。
- 2. 派生类`Circle`
- `继承` ： `Circle` 类从 `Shape` 类继承，表示 `Circle` 是一种形状。
- `构造函数` ： `Circle(double r)` 构造函数用于初始化 `Circle` 对象的半径。
- 实现`纯虚函数` ：
- `area()` ：实现了`计算圆的面积`的逻辑。 
- `draw()`：实现了绘制圆的逻辑，输出 "`Drawing Circle`"。

通过使用抽象类和接口，代码变得更加灵活和可扩展。你可以轻松地添加新的形状类，而不需要修改已有的代码，只需确保新类实现`area` 和 `draw` 函数即可。这种设计降低了代码的耦合度，提高了可维护性。

----