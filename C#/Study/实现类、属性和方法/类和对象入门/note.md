# 类和对象入门

<div>

## 比较结构化编程和面向对象的编程

结构化编程和面向对象的编程（OOP）是软件开发的两种不同的方法，每个方法都有自己的原则和方法集。
- 结构化编程基于一种自上而下的方法，其中程序分为更小、可管理的功能或过程。 此方法强调使用循环、条件和子例程的明确和逻辑控制流。
- 面向对象的编程基于封装数据和行为的对象的概念。 此方法通过围绕相互交互的对象组织软件设计来促进模块化和可重用的代码结构。
### 结构化编程

结构化编程是软件开发的一种方法，它源于提高代码清晰度、代码质量和开发时间的需求。 它依赖于使用控制结构（如循环、条件和子例程）来创建明确的逻辑控制流。 在结构化编程中，程序分为较小的可管理函数或过程，每个函数或过程旨在执行特定任务。 这种模块化方法允许代码重用和简化调试，因为可以单独测试每个函数。 但是，随着软件的复杂性的增加，管理这些函数之间的交互可能会变得具有挑战性。

结构化编程非常适合小型到中型软件项目，其中重点在于控制逻辑流。 它对于可分解为一系列步骤的过程任务有效。 但是，随着软件的大小和复杂性的增长，结构化编程可能会变得不复杂，难以维护。 在大型应用程序中，结构化编程的线性和自上而下的方法可能导致相互依赖的函数的纠缠 Web，使得难以理解和修改代码库。

### 面对对象的编程

面向对象的编程是一种软件开发方法，侧重于对象的概念，它封装了数据（属性）和行为（方法）。 在 OOP 中，软件设计基于`类`，用作创建`对象`的蓝图。 每个对象表示一个真实实体，并且可以通过定义完善的接口与其他对象交互。

面向对象的编程非常适合大型复杂软件系统，因为它鼓励模块化且可维护的代码结构。

### 面对对象编程的术语

在描述 OOP 的概念和优势时，通常使用以下术语：

| 术语名称 | 说明                                                                                                                                      |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| 抽象     | 抽象允许隐藏复杂的实现详细信息，同时公开一组简化的数据属性和方法，供用户与之交互。 它充当用户与对象或系统内部工作之间的边界。             |
| 封装     | 封装是将数据（属性）和方法（函数）捆绑到单个单元（类）的过程。 本单元隐藏有关如何存储或处理数据的内部详细信息，只公开定义完善的交互接口。 |
| 继承     | 继承是一个类获取另一个类的属性和行为的机制。 它允许你创建基于现有类的新类，重用父类的属性和方法。                                         |
| 多态性   | 多态性允许将不同类的对象视为通用超级类的对象。 多态性使你能够编写处理多种类型对象的代码，从而提供灵活性和可扩展性。                       |
</div>

---

## C# 的内置类型

C# 提供一组标准的内置类型。 这些标准类型表示整数、浮点值、布尔表达式、文本字符、小数值和其他类型的数据。 还有内置字符串和对象类型。 这些类型可用于任何 C# 程序。

## 自定义类型

自定义类型可以使用`struct`、`class`、`interface`、`enum`和`record`构造来创建自己的自定义类型。

## 通用类型系统

了解 .NET 中类型系统的两个基本点非常重要：
- 它支持继承原则。 类型可以派生自其他类型，称为基类型。 派生类型继承方法、属性和基类型的其他成员（有一些限制）。 基类型反过来可以派生自某些其他类型，在这种情况下，派生类型继承其继承层次结构中这两种基类型的成员。 所有类型（包括 `System.Int32`（C# 关键字：int）等内置数值类型最终派生自单个基类型，即`System.Object`（C# 关键字：`object`）。 这种统一类型层次结构称为通用类型系统（CTS）。
- CTS 中的每个类型都定义为值类型或引用类型。 这些类型包括 .NET 类库中的所有自定义类型，以及你自己的用户定义的类型。 使用结构关键字定义的类型是值类型;所有内置数值类型都是结构。 使用类或记录关键字定义的类型是引用类型。 引用类型和值类型具有不同的编译时规则和不同的运行时行为。

类和结构是 .NET 中通用类型系统的基本构造之二。 每个结构本质上都是一个数据结构，它封装一组作为逻辑单元属于一起的数据和行为。 数据和行为是`class`顿号`struct`或`record`的成员。 类的成员包括属性（数据）、方法（行为）、字段（类中声明的变量），等等。

`class`、`struct`或`record`声明类似于用于在运行时创建实例或对象的蓝图。 如果定义名为`Person`的类，则`Person`是类型的名称。 如果声明和初始化`p`为`Person`类的变量，则`p`就是`Person`的对象或实例。 可以创建同一`Person`类型的多个实例，并且每个实例在其属性和字段中可以具有不同的值。

`class` 是引用类型。 创建`class`类的对象时，为其分配对象的变量只保留对该内存的引用。 将对象引用分配给新变量时，新变量引用原始对象。 通过一个变量所做的更改反映在另一个变量中，因为它们都引用了相同的数据。
`struct`是值类型。 创建`struct`时，为其分配`struct`的变量将保留`struct`的实际数据。 将`struct`分配给新变量时，将复制数据值。 因此，新变量和原始变量包含同一数据的两个单独的副本。 对一个副本所做的更改不会影响另一个副本。
`record`类可以是引用类型(`record class`)或值类型(`record struct`)。`record`类包含支持值相等性的方法。

一般情况下，`class`用于对更复杂的行为进行建模。 `class`通常存储在创建类对象后要修改的数据。
`struct`最适合小型数据结构。 `struct`通常存储创建`struct`后不打算修改的数据。
`record`类型是具有其他编译器合成成员的数据结构。 `record`通常存储创建对象后不打算修改的数据。

## 值类型

值类型派生自`System.ValueType`，派生自`System.Object`。 从
`System.ValueType`派生的类型在公共语言运行时中具有特殊行为。 值类型变量直接包含其值。`struct`有两类值类型：结构与枚举。

`值类型`。 不能从任何值类型派生类型，例如`System.Int32`。 无法定义从任何用户定义的`struct`或`class`继承的`struct`，因为`struct`只能从`System.ValueType`继承。

使用`struct`关键字创建自己的自定义值类型。 通常，结构用作一小部分相关变量的容器，如例所示：

    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

另一类值类型是`enum`。`enum`定义一组命名整型常量。 例如，.NET 类库中的`System.IO.FileMode`枚举包含一组命名的常量整数，用于指定应如何打开文件。 以下示例显示了`enum`的语法：

    public enum FileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6,
    }

`System.IO.FileMode.Create`常量的值为 2。 但是，对于读取源代码的用户来说，名称更有意义，因此最好使用枚举而不是常量文本数字。

所有`enums`都继承自`System.Enum`，后者继承自`System.ValueType`。 应用于`structs`的所有规则也适用于`enums`。

## 引用类型

`class`、`record`、`delegate`、`array`和`interface`类型都是`引用类型`。

声明引用类型的变量时，它将包含`null`值，直到使用该类型的实例分配它或使用`new`运算符创建一个值。

示例演示如何使用数组声明引用类型变量：

    // Declaring an array variable
    int[] numbers;

    // Initializing the array with a size of 5
    numbers = new int[5];

    // Alternatively, declaring and initializing an array in one line
    int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

    // Assigning a reference to another variable
    int[] numbers3 = numbers2;

**`注意`除了引用类型外，数组也是集合。 可以使用集合表达式初始化集合，这消除了在一行中声明和初始化数组时包括`new`关键字的要求。 例如：`int[] numbers = [ 1, 2, 3, 4, 5 ];`。**

可以使用用于实例化内置类型的相同语法创建类的实例。下面示例演示如何创建类的示例:

    MyClass myClass = new MyClass();
    MyClass myClass2 = myClass;

运算符创建类的实例，并返回对该实例的引用。 引用是对象的内存地址，该引用存储在变量中。 将引用类型变量分配给另一个变量时，将复制引用，而不是对象本身。 这两个变量都引用内存中的同一对象。

</div>

---

## 设计和使用类

在面向对象的编程（OOP）中，类是应用程序的构建基块。 了解类和对象之间的关系至关重要。

- 类是开发人员用来定义对象的属性（数据）和方法（行为）的蓝图。 类提供了一种封装数据和行为的方法，以便更轻松地组织和管理代码。
- 对象是类的实例。 实例化类时，在内存中创建对象。 每个对象都有自己的一组属性和方法，但共享由类定义的相同结构。

## 实际对象

人们在日常生活中不断与物体进行交互。 事实上，我们与之交互的几乎一切都可以视为一个对象。

以下条件可用于定义现实世界中的对象：
- 对象是我们可以看到和触摸的对象。
- 对象具有用途。
- 对象具有支持其用途的部分。

### 物理对象的属性和功能

对象的属性通常分为以下物理和行为类别：
- 物理：物理属性是可以看到或测量的对象的各个方面。
- 行为：行为属性是描述其功能或与其他对象的交互的对象的各个方面。

物理属性通常称为属性，而行为属性通常称为函数（C# 编程中的方法）。

### C# 编程中的代码类和对象

在 C# 编程世界中，对象属性和方法由类定义。 类提供对象（类实例）能够执行的作的蓝图。 类的蓝图称为类定义。

当应用运行时，计算机使用类定义为对象（类的实例）分配内存。 计算机使用蓝图来配置大小正确的内存块。 对象基本上是内存块。

与物理对象一样，代码对象可以为其属性分配不同的值。

### 类属性

类属性用于管理将一个对象（类实例）与同一类型的另一个对象区分开的数据。

类属性使对象能够读取、写入或计算类中定义的变量（数据字段）的值。 属性显示为公共数据成员，但它们作为称为`访问器的特殊方法实现`。 此功能使调用方能够轻松访问数据，并且仍有助于提升数据安全性和灵活性。

可以使用`get`访问器读取属性值，并使用`set`访问器进行分配。

### 类方法

类方法定义类可以执行的操作（行为）。

方法可以采用提供输入数据的参数，并通过参数返回输出数据。 方法还可以直接返回值，而无需使用参数。
例如，`Console`类包括`WriteLine`、`ReadLine`和`Clear`方法（等等）。 这些方法有助于启用`Console`类的预期行为。 方法可用于执行操作，例如计算、数据操作或与其他对象的交互。

方法通常设计为接受一个或多个方法参数。 方法参数作为用于调用方法的调用语句的参数传递给该方法。 例如，`Console`类的`WriteLine`方法可以接受由调用语句提供的字符串参数。

### C# 代码中的类定义

以下示例演示 C# 中的简单类。

`Phone`类具有`Brand`、`Model`和`Year`的属性。 该类还包括用于`Call`和`Text`的方法。

    public class Phone
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }

        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine($"Texting {phoneNumber}: {message}");
        }
    }

## 使用命名空间

在 C# 编程中，命名空间采用两种方式：
- .NET 类库使用命名空间来组织其许多类。
- 开发人员声明自己的命名空间，以帮助控制大型编程项目中的类和方法名称的范围。

### .NET 类库中的命名空间

    System.Console.WriteLine("Hello World!");

在上面示例中，`System`是一个命名空间，`Console`是该命名空间中的类。
提供类（`System.Console`）的完全限定名称可确保使用正确的类。 但是，使用同一命名空间中的许多类时，使用完全限定的名称可能很麻烦。 若要提高代码可读性，可以使用`using`指令。
`using`指令允许使用命名空间中定义的类型，而无需指定该类型的完全限定命名空间。

    using System;

    Console.WriteLine("Hello World!");

**`注意`从 .NET 6 开始，`隐式`global using指令添加到新的 C# 项目中。 这意味着可以使用在这些命名空间中定义的类型，而无需指定其完全限定的名称或手动添加 using 指令。
`隐式`方面是指将全局 using 指令添加到项目的 obj 目录中生成的文件中的事实。 使用此功能可以在 .NET 版本 6.0 或更高版本中开发应用时使用`Console.WriteLine`，而无需显式声明。**

### 使用命名空间组织类

声明自己的命名空间有助于控制大型编程项目中的类和方法名称的范围。 使用`namespace`关键字声明命名空间。

    namespace SampleNamespace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                System.Console.WriteLine("SampleMethod inside SampleNamespace");
            }
        }
    }

命名空间的名称必须是有效的 C# 标识符名称。

可以为该文件中定义的所有类型声明命名空间，如以下代码片段所示：

    namespace SampleNamespace;

    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine("SampleMethod inside SampleNamespace");
        }
    }

    class AnotherSampleClass
    {
        public void AnotherSampleMethod()
        {
            System.Console.WriteLine("AnotherSampleMethod inside SampleNamespace");
        }
    }

这种新语法的优点是，它更简单，可以节省水平空间和大括号。 这使得代码更易于阅读。

### 命名空间概述

命名空间具有以下属性
- 它们组织大型代码项目。
- 它们使用`.`运算符进行分隔。
- `using`指令将要求指定每个类的命名空间的名称。
- 全局命名空间是“根”命名空间：`global::System`始终引用 .NET 系统命名空间。

使用命名空间将相关类型组合在一起可以更轻松地查找和使用它们。

</div>

---

## 类构造函数

类构造函数是一个与其类型同名的方法（构造函数方法使用与类相同的名称）。

有两种类型的类构造函数：
- 实例构造函数。 实例构造函数用于在创建对象时创建和初始化任何实例字段变量。
- 静态构造函数。 静态构造函数用于初始化任何静态数据，或执行需要仅执行一次的特定操作。 在创建第一个实例或引用任何静态成员之前，会自动调用静态构造函数。

类构造函数默认为实例构造函数。

### 实力构造函数语法

实例构造函数使用与类相同的名称声明，并且不包含返回类型。 构造函数的方法签名可以包括可选的访问修饰符、方法名称及其参数列表。 构造函数的方法签名不包括返回类型。

`Person`的类的简单构造函数示例： 

    public class Person
    {
        public Person()
        {
            // Field initialization and constructor logic goes here.

        }

        // Remaining implementation of Person class.
    }

类可以有多个构造函数。 当类具有多个构造函数时，构造函数通常采用不同的参数。

`Person`类，其中包含两个构造函数。

    public class Person
    {

        public Person()
        {
            // Field initialization and constructor logic goes here.
            string name = "Person One";
            Console.WriteLine($"Person created: {name}");

        }

        public Person(string fName, string lName)
        {
            string name = fName + " " + lName;

            Console.WriteLine($"Person created: {name}");
       }

       // Remaining implementation of Person class.
    }

## 使用类构造函数实例化对象

使用`new`关键字实例化对象时，.NET 运行时在类定义中调用关联的实例构造函数，并为该对象分配内存。

下面代码示例中，`Person`类定义一个简单的实例构造函数。`Program`类包括一个`Main`方法，该方法使用`new`运算符创建名为`Person`的`person1`实例。 运行时在为新对象分配内存后立即调用`Person`构造函数。

    public class Person
    {
        public Person()
        {
            // Field initialization and constructor logic goes here.

        }
    }

    static class Program
    {
        // the Main method is the entry point of the program.
        static void Main()
        {
            Person person1 = new Person();
        }
    }

### 不使用参数的构造函数

不采用任何参数的构造函数称为无参数构造函数。 当使用`new`运算符实例化对象且未向构造函数提供任何参数时，运行时将调用无参数构造函数。
**`注意`除非类是静态的，否则没有构造函数的类由 C# 编译器提供公共无参数构造函数，以便启用类实例化。**

类通常定义采用参数的构造函数。 必须使用`new`运算符或基语句调用采用参数的构造函数。 类可以定义一个或多个构造函数。

    public class Person
    {

        public Person()
        {
            // Field initialization and constructor logic goes here.

            Console.WriteLine("An instance of the Person class is being instantiated without name or age parameters.");
        }

        public Person(string name)
        {
            // Field initialization and constructor logic goes here.

            Console.WriteLine($"An instance of the Person class is being instantiated using a name ({name}) parameter.");
        }

        public Person(string name, int age)
        {
            // Field initialization and constructor logic goes here.

            Console.WriteLine($"An instance of the Person class is being instantiated using name ({name}) and age ({age}) parameters.");
        }
    }

    static class Program
    {
        // the Main method is the entry point of the program.
        static void Main()
        {
            Person person1 = new Person();
            Person person2 = new Person("Person Two");
            Person person3 = new Person("Person Three", 30);
        }
    }

上面代码示例显示了一个名为`Person`的类，其中就包含了三个构造函数

### 没有构造函数的类

如果类没有显式实例构造函数，C# 提供了一个可用于实例化该类实例的无参数构造函数，如以下示例所示：

    public class Person
    {
        public int age;
        public string name = "unknown";
    }

    class Example
    {
        static void Main()
        {
            var person = new Person();
            Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            // Output:  Name: unknown, Age: 0
        }
    }

此构造函数根据相应的初始值设定项初始化实例字段和属性。 如果字段或属性没有初始值设定项，则其值设置为字段或属性类型的默认值。 如果在类中声明了至少一个实例构造函数，C# 不提供无参数构造函数。

### 使用构造函数参数初始化类数据

传递给构造函数的参数是构造函数的本地参数。 参数通常用于初始化类的数据字段。

下面示例显示了一个名为`Person`的类，其中包含用于初始化`personName`和`personAge`字段的构造函数：

    public class Person
    {
        public string personName;
        public string personAge;

        public Person()
        {
            // Field initialization and constructor logic goes here.
            personName = "unknown";
            personAge = "unknown";
        }

        public Person(string name)
        {
            // Field initialization and constructor logic goes here.
            personName = name;
            personAge = "unknown";
        }

        public Person(string name, int age)
        {
            // Field initialization and constructor logic goes here.
            personName = name;
            personAge = age.ToString();
        }
    }

    static class Program
    {
        // the Main method is the entry point of the program.
        static void Main()
        {
            Person person1 = new Person();
            Person person2 = new Person("Person Two");
            Person person3 = new Person("Person Three", 30);

            Console.WriteLine($"Person 1 Name: {person1.personName} Age: {person1.personAge}");
            Console.WriteLine($"Person 2 Name: {person2.personName} Age: {person2.personAge}");
            Console.WriteLine($"Person 3 Name: {person3.personName} Age: {person3.personAge}");
        }
    }

在上面的示例中，`Person`类使用三个构造函数定义。 第一个构造函数将`personName`和`personAge`字段初始化为`"unknown"`。 第二个构造函数将`personName`字段初始化为`name`参数中传递的值，并将`personAge`字段初始化为`"unknown"`。 第三个构造函数将`personName`和`personAge`字段分别初始化`name`和`age`参数中传递的值。

由于字段是公共的，因此可以直接从`Main`方法访问这些字段。 代码运行时，将生成以下输出：

    Person 1 Name: unknown Age: unknown
    Person 2 Name: Person Two Age: unknown
    Person 3 Name: Person Three Age: 30

## 静态构造函数

静态构造函数用于初始化任何静态数据，或执行需要仅执行一次的特定操作。 在创建第一个实例或引用任何静态成员之前，系统会自动调用它。 静态构造函数最多调用一次。

以下代码示例显示了实现静态字段和静态构造函数的`Person`类的更新版本：

    public class Person
    {
        public string personName;
        public string personAge;

        // Static field
        public static string defaultName;
        public static string defaultAge;

        // Static constructor
        static Person()
        {
            // Static field initialization
            defaultName = "unknown";
            defaultAge = "unknown";
        }

        public Person()
        {
            // Field initialization and constructor logic goes here.
            personName = defaultName;
            personAge = defaultAge;
        }

        public Person(string name)
        {
            // Field initialization and constructor logic goes here.
            personName = name;
            personAge = defaultAge;
        }

        public Person(string name, int age)
        {
            // Field initialization and constructor logic goes here.
            personName = name;
            personAge = age.ToString();
        }
    }

更新的`Person`类有两个实例字段，`personName`和`personAge`，两个实例字段的类型均为`string`。 这些字段分别存储人员的姓名和年龄。

该类还定义了两个静态字段，`defaultName`和`defaultAge`，也是`string类型。 静态字段在类的所有实例之间共享，并且仅初始化一次。 在这种情况下，静态字段用于提供`personName`和`personAge`字段的默认值。

静态构造函数`static Person()`负责初始化静态字段。 它将`defaultName`设置为`"unknown"`，并将`defaultAge`设置为`"unknown"`。 在创建类的任何实例或访问任何静态成员之前，会自动调用静态构造函数。

`Person`类包括三个实例构造函数：

无参数构造函数`public Person()`使用静态字段的值初始化`personName`和`personAge`字段`defaultName`和``defaultAge`。 这意味着，如果在创建`Person`对象时未提供任何参数，则`"unknown"`默认值用于名称和年龄。

构造函数`public Person(string name)`采用单个参数`name`，并使用此值初始化`personName`字段。`personAge`字段使用静态字段`defaultAge`的值进行初始化。 此构造函数允许在使用默认期限时创建具有指定名称的`Person`对象。

构造函数`public Person(string name, int age)`采用两个参数，`name`和`age`。 它用`personName`参数的值和具有 age 参数字符串表示形式的`name`字段初始化`personAge`字段。 此构造函数允许创建具有指定`Person`和`name`的`age`对象。

### 静态构造函数的属性

静态构造函数具有以下属性：
- 静态构造函数不采用访问修饰符或具有参数。
- 类只能有一个静态构造函数。
- 无法继承或重载静态构造函数。
- 静态构造函数不能直接调用，只能由公共语言运行时（CLR）调用。 它会自动调用。
- 用户在程序中执行静态构造函数时没有控制权。
- 自动调用静态构造函数。 在创建第一个实例之前，它会初始化该类，或者引用该类（而不是其基类）中声明的任何静态成员。 静态构造函数在实例构造函数之前运行。 如果静态字段变量初始值设定项存在于静态构造函数的类中，则它们以在类声明中显示的文本顺序运行。 初始值设定项在静态构造函数之前立即运行。
- 如果未提供用于初始化静态字段的静态构造函数，则所有静态字段都会初始化为其默认值。
- 如果静态构造函数引发异常，运行时不会再次调用它，并且该类型在应用程序域的生存期内保持未初始化状态。 最常见的情况是，当静态构造函数无法实例化类型或静态构造函数中发生的未经处理的异常时，将引发`TypeInitializationException`异常。 对于未在源代码中显式定义的静态构造函数，故障排除可能需要检查中间语言 （IL） 代码。
- 静态构造函数的存在可防止添加`BeforeFieldInit`类型属性。 这会限制运行时优化。
- 声明为`static readonly`的字段只能作为声明的一部分或在静态构造函数中分配。 当不需要显式静态构造函数时，请在声明中初始化静态字段，而不是通过静态构造函数来更好地优化运行时。
- 运行时在单个应用程序域中调用静态构造函数不超过一次。 该调用基于类的特定类型在锁定区域中进行。 静态构造函数正文中不需要额外的锁定机制。

**`注`虽然无法直接访问，但应记录显式静态构造函数的存在，以帮助排查初始化异常问题。**

</div>

---