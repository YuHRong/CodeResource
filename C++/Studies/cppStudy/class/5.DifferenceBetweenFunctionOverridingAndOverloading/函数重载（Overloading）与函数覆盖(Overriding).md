# 函数重在(Overloading) 与 函数覆盖 （Overriding）

## 函数重在 Overloading

函数重载是指在同一个作用域内定义多个同名函数，但这些函数的参数列表不同（参数的个数或类型不同）。编译器根据传递的参数类型和数量来决定调用哪个函数。

### 规则

- 函数名相同。
- 参数列表不同（参数的个数或类型不同）。
- 返回类型可以相同也可以不同，但返回类型不能作为区分重载函数的依据。

#### 示例： 

```cpp
#include <iostream>

// 无参数重在函数
void print()
{
 std::cout << "No parameters" << std::endl;
}

// 一个整形参数重在函数
void print(int i)
{
 std::cout << "Integer: " << i << std::endl;
}

// 一个双精度浮点数重在函数
void print(double d)
{
 std::cout << "Double: " << d << std::endl;
}

// 两个整形参数重在函数
void print(int i, int j)
{
 std::cout << "Two integers: " << i << ", " << j << std::endl;
}

int main()
{
 print();
 print(10);
 print(3.14);
 print(5, 15);

 return 0;
}
```

函数重载通过允许多个同名函数存在，提高了函数的灵活性和易用性，使得同一个函数名可以处理不同类型和数量的参数。

## 函数覆盖 （Overriding）

函数覆盖是指子类重新定义基类中已有的虚函数。覆盖发生在继承关系中，目的是在派生类中提供特定于该类的实现。

### 规则

- 函数名相同。
- 参数列表相同。
- 返回类型相同（或协变返回类型）。
- 基类函数必须标记为`virtual`。
- 子类函数可以选择性地使用`override`关键字（推荐使用）。

#### 示例： 

```cpp
#include <iostream>

class Base
{
public:
 virtual void show()
 {
  std::cout << "Base class" << std::endl;
 }
};

class Derived : public Base
{
public:
 void show() override
 {
  std::cout << "Derived class" << std::endl;
 }
};

int main()
{
 Base *b;
 Derived d;
 b = &d;
 b->show(); // 调用 Derived 类中的 show() 函数

 return 0;
}
```

函数覆盖在继承关系中使用，通过在子类中重新定义基类的虚函数，可以实现多态性，使得基类指针或引用在运行时调用派生类的函数版本。

## 重载与覆盖的区别

1. 作用范围不同
- `重载`：发生在同一个作用域内，可以是同一个类中，也可以是全局作用域中的重载函数。
- `覆盖`：发生在继承关系中，即基类和派生类之间。
2. 目的不同
-  `重载`：目的是使用相同的函数名来处理不同的参数类型和数量，从而提高代码的灵活性和可读性。
- ` 覆盖`：目的是在派生类中提供特定于该类的实现，从而实现多态性。
3. 参数列表要求不同
- `重载`：要求参数列表不同（参数个数或类型不同）。
- `覆盖`：要求参数列表相同。
4. 返回类型要求不同
- `重载`：返回类型可以不同，但不能仅通过返回类型来区分重载函数。
- `覆盖`：返回类型必须相同或协变（即派生类重载函数的返回类型可以是基类函数返回类型的派生类）。
5. 基类函数要求不同
- `重载`：不要求基类函数是虚函数。
- `覆盖`：基类函数必须是虚函数。
6. 关键字使用
- `重载`：不需要特定的关键字。
- `覆盖`：推荐在子类覆盖的函数中使用 `override`关键字，以明确表示这是一个覆盖操作，避免无意中进行隐藏。

### 对比实力

```cpp
#include <iostream>

class Base
{
public:
 // 重载函数，基类中有两个同名函数，参数不同
 void display()
 {
  std::cout << "Display without parameters in Base" << std::endl;
 }

 void display(int i)
 {
  std::cout << "Display with int parameter in Base: " << i << std::endl;
 }

 // 虚函数，准备在派生类中进行覆盖
 virtual void show()
 {
  std::cout << "Show in Base" << std::endl;
 }
};

class Derived : public Base
{
public:
 // 重载函数，派生类中有两个同名函数，参数不同
 void display()
 {
  std::cout << "Display without parameters in Derived" << std::endl;
 }

 void display(double d)
 {
  std::cout << "Display with double parameter in Derived: " << d << std::endl;
 }

 // 覆盖函数，重新定义基类中的虚函数
 void show() override
 {
  std::cout << "Show in Derived" << std::endl;
 }
};

int main()
{
 Base b;
 Derived d;

 // 调用基类中的重载函数
 b.display();
 b.display(100);

 // 调用派生类中的重载函数
 d.display();
 d.display(3.14);

 // 调用基类和派生类中的覆盖函数
 Base *ptr = &d;
 ptr->show(); // 输出 "Show in Derived" 表明调用的是派生类的覆盖函数

 return 0;
}
```

在这个例子中，我们既展示了函数重载又展示了函数覆盖。通过实例化`Base`和`Derived`类，并调用它们的成员函数，我们可以清楚地看到重载和覆盖的不同行为。

### 结论

重载和覆盖是C++中的两个重要概念，它们在不同的场景下提供了不同的功能。重载通过使用相同的函数名来处理不同的参数类型和数量，提升了代码的灵活性和可读性。而覆盖通过在继承关系中重新定义基类的虚函数，实现了多态性和运行时的动态绑定。理解这两个概念及其区别，有助于更好地掌握C++的面向对象编程，提高代码的质量和可维护性。