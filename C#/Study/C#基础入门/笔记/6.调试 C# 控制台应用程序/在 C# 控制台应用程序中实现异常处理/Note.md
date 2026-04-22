
## 异常处理过程


## try-catch执行步骤

```c#
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}
```

在此示例中，将发生以下过程：
1. 执行过程从外部 `try` 语句的代码块开始。
2. 在内部 `try` 语句的代码块中引发异常。
3. 运行时查找与外部 `catch` 语句关联的 `try` 子句。
4. 在运行时将控制权转移到 `catch` 代码块的第一行之前，它会执行与内部 `finally` 语句关联的 `try` 子句。
5. 然后，运行时将控制权传输到代码块的第一行 `catch`，并执行处理异常的代码。

在此简单示例中，嵌套 `try-catch` 模式和 `try-finally` 模式驻留在单个方法中，但多个 `try-catch` 模式 `try-finally` 可以分布在调用其他方法的方法之间。

## 异常处理和调用堆栈

当你读到异常处理和异常处理过程时，通常会看到“调用堆栈展开”这个术语。 若要了解此术语，需要了解调用堆栈以及如何在代码执行期间跟踪方法调用的“堆栈”。

可以将调用堆栈想象成一座由很多块组成的塔。 当你建造一座塔时，你从一个块开始。 每次向塔添加一个块时，都会将它放在现有块的上面。 当应用程序在调试器中开始运行时，应用程序的入口点是添加到调用堆栈（塔的第一个块）的第一层。 每次方法调用另一个方法时，新方法都会添加到堆栈的顶部。 当代码从一个方法中退出时，该方法将从调用堆栈中删除。


*注意*对于控制台应用程序，应用程序的入口点是顶层语句。 在 Visual Studio Code 调用堆栈中，此入口点称为`Main`方法。  

调用堆栈展开是 .NET 运行时在 C# 程序遇到错误时使用的过程。 这也是你刚查看的过程。

回到积木塔的比喻，当你需要从塔中取出一个积木块时，从顶部开始，依次取出每个积木块，直到取出所需的那块积木。 此过程类似于调用堆栈展开的工作过程，其中堆栈中的每个调用层就像塔中的一个块。 当运行时需要展开调用堆栈时，它会从顶部开始删除每个调用层，直到到达所需的那个调用层。 在本例中，它所需的调用层是具有`catch`子句的方法，该子句可以处理发生的异常。

在本单元中，应谨记以下几个重要事项<br>  

可能需要异常处理的常见方案包括用户输入、数据处理、文件 I/O作、数据库作和网络通信。

C# 中的异常处理是使用`try`和`catch`<b>finally<b>关键字实现的。 每个关键字都有一个关联的代码块，该块用于特定目的。
- 异常表示为类型，派生自`System.Exception`.NET 中的类。 异常包含标识异常类型的信息，以及提供其他详细信息的属性。
- 当发生异常时，.NET 运行时会搜索最近的可处理该异常的`catch`子句。 搜索从引发异常的方法开始，并在必要时向下移动调用堆栈。

---

异常由 .NET 运行时或程序中的代码生成。 异常类型依赖于导致异常的代码。

## 编译器生成的异常

当基本操作失败时，.NET 运行时会引发异常。 下面是运行时异常及其错误条件的简短列表<br>
- ArrayTypeMismatchException<br>当数组无法存储给定元素时引发，因为该元素的实际类型与数组的实际类型不兼容。
- DivideByZeroException<br>尝试将整数值除以零时引发。
- FormatException<br>参数格式无效时引发。
- IndexOutOfRangeException<br>在索引小于零或超出数组边界的情况下，尝试为数组编制索引时引发。
- InvalidCastException<br>当从基类型到接口或派生类型的显式转换在运行时失败时引发。
- NullReferenceException<br>尝试引用值为 null 的对象时引发。
- OverflowException<br>当被选中上下文中的算术运算溢出时引发。
编译器生成的异常的代码## 示例

下面的代码示例演示导致编译器生成的异常的代码示例。

### 数组类型不匹配异常

当尝试在数组中存储错误类型的元素时，将引发类型的  ArrayTypeMismatchException  异常。 以下示例在尝试在字符串数组中存储数值时引发  ArrayTypeMismatchException 异常。

```C#
string[] names = { "Dog", "Cat", "Fish"  };
Object[] objs = (Object[])names;

Object obj = (Object)13 ;
objs[2] = obj; // ArrayTypeMismatchException occurs
```

### DivideByZeroException

尝试将整数或十进制数除以零时，会发生类型的  DivideByZeroException 异常。 以下示例在执行整数除法时引发  DivideByZeroException 异常。

```C#
int number1 = 3000;

int number2 = 0 ;
Console.WriteLine(number1 / number2); 
// DivideByZeroException occurs
```

*注意*将浮点值除以零不会引发异常;它根据 `IEEE 754` 算术规则，产生正无穷大、负无穷大或非数字（`NaN`）。

### FormatException

当参数的格式无效或复合格式字符串格式不正确时，会发生类型的  FormatException  异常。 以下示例在尝试将字符串转换为整数时引发  FormatException 异常。
```C#
int valueEntered;

string userValue = "two" ;
valueEntered = 
int.Parse(userValue); // FormatException occurs
```

### IndexOutOfRangeException

当尝试访问具有超出其边界的索引的数组或集合的元素时，将引发类型的  IndexOutOfRangeException 异常。 以下示例在尝试将  IndexOutOfRangeException 数组的最后一个元素赋值给  values1 数组的最后一个元素时引发  values2 异常。
```C#
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };

int[] values2 = new int[6 ];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
```

### InvalidCastException

尝试进行无效的强制转换或显式转换时，将引发类型为  InvalidCastException 的异常。 以下示例会在尝试将  InvalidCastException 类型的字符串强制转换为  object 变量时引发  int。

```C#
object obj = "This is a string";

int num = (int)obj;
```

### NullReferenceException

尝试访问其值为 null 的类型上的成员时，将引发类型的  NullReferenceException  异常。 显示了两个示例。 首个示例中，当尝试访问空数组的元素时，会抛出  NullReferenceException 。 第二个示例在尝试访问空字符串的方法时抛出 NullReferenceException。

```C#
int[] values = null;

for (int i = 0; i <= 9 ; i++)
    values[i] = i * 2;
```

---

```C#
string? lowCaseString = null ;
Console.WriteLine(lowCaseString.ToUpper());
```

### OverflowException

当算术运算尝试分配超出目标数据类型范围的结果时，会发生类型的  OverflowException 异常。 以下示例在尝试将 OverflowException值400转换为 decimal变量时抛出 byte异常。

```C#decimal x = 400;

byte  i;

i = (byte)x; // OverflowException occurs

Console.WriteLine(i);
```

## 总结

在本单元中，应谨记以下几个重要事项:
- 当操作失败时，.NET 运行时将引发异常。  
- 异常类型依赖于导致异常的代码。  
- 应用程序应捕获运行时异常。

---

