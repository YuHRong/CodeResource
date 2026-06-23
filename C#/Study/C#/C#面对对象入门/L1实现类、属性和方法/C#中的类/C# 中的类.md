
# C# 中的类

## 引用类型

定义为`class` 的类型是引用类型。

。 在运行时，如果声明引用类型的变量，此变量就会一直包含值
null
，直到使用
new
运算符显式创建类实例，或直到为此变量分配已在其他位置创建的兼容类型，如示例所示：

// 申明 MyClass 类型的对象

MyClass mc = new MyClass();

//声明另一个相同类型的对象，并为其分配第一个对象的值。

MyClass mc2 = mc;


## 申明类

使用 `class` 跟随在标识符后关键字可以声明类，如下例所示：


//[访问修饰符]-[类]-[标识符]
public class Customer
{
 //字段、属性、方法和事件都在这里。..
}

class 前面是可选修饰符， class 的访问权限为`内部访问`(internal)

## 创建对象

虽然它们有时可以互换使用，但类和对象是不同的概念。 类定义对象类型，但不是对象本身。 对象是基于类的具体实体，有时称为类的实例。
可通过使用
new
关键字，后跟类的名称来创建对象，如下所示：

Customer object1 = new();

当创建一个类的实例时，对象的引用会传递回程序员。 在上一示例中，
object1
是对基于
Customer
的对象的引用。 该引用指向新对象，但不包含对象数据本身。 事实上，可以创建对象引用，而完全无需创建对象本身：

Customer object2;

不建议创建不引用对象的对象引用，因为尝试通过这类引用访问对象会在运行时失败。 引用可以通过创建新对象或将其引用至现有对象来指向一个对象。

Customer object3 = new();
Customer object4 = object3;

此代码创建指向同一对象的两个对象引用。 因此，通过
object3
对对象做出的任何更改都会在后续使用
object4
时反映出来。 由于基于类的对象通过引用来引用，因此类称为引用类型。


## 构造函数和初始化

前面的部分介绍了声明类类型并创建该类型的实例的语法。 创建类型的实例时，需要确保其字段和属性已初始化为有用的值。 可通过多种方式初始化值：

- 接受默认值

- 字段初始化器

- 构造函数参数

- 对象初始值设定项

当 .NET 默认值不是正确的值时，可以使用
字段初始化表达式
设置初始值：

public class Container
{
    // Initialize capacity field to a default value of 10:
    private int _capacity = 10;
}

可以通过定义负责设置初始值的
构造函数
来要求调用方提供初始值：

public class Container
{
    private int _capacity;

    public Container(int capacity) => _capacity = capacity;
}


从 C# 12 开始，可以将
主构造函数
定义为类声明的一部分：

public class Container(int capacity)
{
    private int _capacity = capacity;
}

向类名添加参数可定义
主构造函数
。 这些参数在类的主体中可用，主体包括其成员。 可以将其用于初始化字段或需要它们的任何其他位置。
还可以对某个属性使用
required
修饰符，并允许调用方使用
对象初始值设定项
来设置该属性的初始值：

public class Person
{
 public required string LastName { get; set; }
 public required string FirstName { get; set; }
}

添加
required
关键字要求调用方必须将这些属性设置为
new
表达式的一部分：

var p1 = new Person(); // Error! Required properties not set
var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };

## 类继承

类完全支持 继承  ，这是面向对象的编程的基本特点。 创建类时，可以从其他任何未定义为 
sealed  的类继承。 其他类可以从你的类继承并替代类虚拟方法。 此外，你可以实现一个或多个接口。
继承是通过使用 派生 来完成的，这意味着类是通过使用其数据和行为所派生自的 基类 
来声明的。 基类通过在派生的类名称后面追加冒号和基类名称来指定，如：

public class Manager : Employee
{
    // Employee fields, properties, methods and events are inherited
    // New Manager fields, properties, methods and events go here...
}