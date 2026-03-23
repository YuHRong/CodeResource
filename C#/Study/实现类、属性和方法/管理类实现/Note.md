# 管理类实现

<div>

## 将 Object-Oriented 编程与结构化编程进行比较

结构化编程和面向对象的编程（OOP）是软件开发的两种不同的方法，每个方法都有自己的原则和方法集。 结构化编程基于一种自上而下的方法，其中程序分为更小、可管理的功能或过程。 此方法强调使用循环、条件和子例程的明确和逻辑控制流。 面向对象的编程围绕封装数据和行为的对象组织软件设计，从而提升更模块化和可重用的代码结构。 虽然结构化编程侧重于要执行的操作序列，但面向对象的编程强调操作所涉及的对象。

### 结构化编程示例

想象一下结构化编程，使用一个被子。 在此隐喻中，每个构造部分都表示程序中的函数或过程。 就像被子由许多单独的补丁组成，一个结构化程序由各种功能组成，旨在执行特定任务。 每个函数都类似于可以独立开发、测试和维护的修补程序。 按特定顺序将这些补丁缝在一起时，可以创建一个完整的被子，就像合并函数以形成完整的程序一样。

在结构化编程中，重点是控制逻辑流，就像分位器如何规划布局和修补程序序列来创建一个凝聚力的设计一样。 仲裁程序可确保每个补丁与其他人完美配合，保持清晰有序的模式。 同样，结构化程序员可确保每个函数无缝地适应整个程序，并通过使用循环、条件和子例程来保持清晰和逻辑的控制流。

这种被子隐喻突出了结构化编程的模块化特性，每个函数（或修补程序）可以根据需要重复使用和重新排列。 正如仲裁程序可以替换或修改单个修补程序而不中断整个被子一样，程序员可以更新或优化单个函数，而不会影响整个程序。 这种模块化使结构化编程成为创建清晰、可维护且可重用的代码的有效方法。 但是，随着程序的大小和复杂性的增长，管理函数之间的交互可能会变得更加具有挑战性。 正如包含过多修补程序的被子可能会变得笨拙且难以管理一样，具有大量功能和过程的结构化程序可能会变得繁琐且难以维护。 随着修补程序（函数）的数量的增加，跟踪它们如何组合和交互变得更加具有挑战性。 这会导致代码重复、调试困难和缺乏凝聚力等问题。 在大型应用程序中，结构化编程的线性和自上而下的方法可能导致相互依赖的函数的纠缠 Web，使得难以理解和修改代码库。 这种复杂性可能会阻碍可伸缩性和可维护性，最终影响软件的整体质量和性能。
</div>

<div>

## 检查 Object-Oriented 编程中的类的使用

类是面向对象的编程（OOP）的构建基块，用于定义程序中对象的结构和行为。 了解封装和类生命周期提供的优势有助于了解面向对象的编程的工作原理。

### 封装

封装是面向对象的编程（OOP）的基本原则之一。 它是指将数据（字段）和方法（行为）捆绑在一个单元（通常是类）中。 封装会限制对某些对象组件的直接访问，这可以防止意外修改数据。

封装具有以下优势：
- 数据隐藏：封装允许对象的内部状态从外部隐藏。 这意味着可以更改对象的内部表示形式，而不会影响使用该对象的外部代码。 例如，通过使用专用字段并提供公共 getter 和 setter 方法，可以控制数据的访问和修改方式。
- 改进了可维护性：封装使维护和修改代码更容易。 对类的内部实现的更改不会影响使用该类的代码，前提是公共接口保持不变。 这种关注点分离使开发人员能够专注于代码的特定部分，而无需担心意外的副作用。
- 提高灵活性：封装允许更灵活和模块化的代码。 通过定义明确的接口，可以轻松替换或更新代码的各个部分，而不会影响其他部分。 这种模块化使重复使用代码并从更简单的组件生成复杂系统变得更加容易。
- 增强的安全性：封装通过防止未经授权的访问和修改来帮助保护对象数据的完整性。 通过方法控制对数据的访问，可以强制实施对数据的使用方式的规则和约束。 此强制措施有助于防止 bug，并确保对象保持有效状态。
- 抽象：封装通过仅向外部世界公开对象的必要详细信息，支持抽象的概念。 这简化了接口，并使它更易于理解和使用对象。 对象的用户不需要知道内部实现，这可降低代码复杂性并提高可读性。

**`注意`封装是隐藏类用户不需要的数据成员。 使用`private`访问器关键字封装或隐藏数据成员。 使用属性和方法控制对隐藏字段变量的访问。 无法直接访问隐藏的数据成员。**

    public class Person
    {
        // Private fields
        private string firstName;
        private string lastName;
        private int age;

        // Public properties with getters and setters
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age can't be negative");
                }
            }
        }

        // Public method
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName}, and I'm {Age} years old.");
        }
    }

在上面示例中
- 字段`firstName`、`lastName`和`age``private`，这意味着不能直接从类外部访问它们。
- 公共属性`FirstName`、`LastName`和`Age`提供对专用字段的控制访问权限。
- `Age`属性包括验证逻辑，以确保不能将年龄设置为负值。
- `Introduce`方法提供了一种在不公开内部实现详细信息的情况下与对象数据交互的方法。

### 类生命周期

在 C# 应用程序中，类的生命周期涉及从其定义到最终销毁的几个阶段。 类的生命周期包括以下步骤：
1. 类定义：使用其成员定义类。
2. 编译：将类编译为 IL 代码。
3. 加载：将程序集加载到内存中。
4. 实例化：创建类的实例。
5. 初始化：初始化对象的字段和属性。
6. 用法：使用应用程序中的对象。
7. 垃圾回收：不再需要对象时回收对象的内存。
8. 销毁：执行清理逻辑并释放内存。

示例： 

1. `类定义`定义：类在其属性、方法和其他成员的源代码中定义。

```
public class Person
{
    // auto-implemented properties for name and age
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // method to introduce the person
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {FirstName} {LastName}, and I'm {Age} years old.");
          }
}
```

2. `编译`:源代码由 C# 编译器编译为中间语言（IL）。 IL 代码存储在程序集（DLL 或 EXE 文件中）。

例如：`Person`类编译为 IL 代码，并包含在程序集中。

3. `加载`：当应用程序运行时运行时（CLR）将程序集加载到内存中。

例如：包含`Person`类的程序集由 CLR 加载到内存中。

4. 实例化：使用`new`关键字创建类的实例。 调用类的构造函数来初始化对象。

```
Person person1 = new Person { FirstName = "Tim", LastName = "Shao", Age = 25 };
```

5. `初始化`：构造函数初始化对象的字段和属性。 执行构造函数中定义的任何初始化逻辑。

示例：使用`Person`、`person1`和`FirstName`的指定值初始化`LastName`对象`Age`。

6. `用法`：对象在应用程序中使用。 根据需要访问和修改对象的方法和属性。

```
person1.Introduce();
```

7. `垃圾回收`：当不再需要对象且没有引用对象时，垃圾回收器（GC）将回收对象使用的内存。 如果定义了析构函数（终结器），将调用它。
示例：如果代码中的任何位置不再引用`person1`，GC 最终将回收其内存。

8. `销毁`：释放对象的内存，并执行析构函数（如果指定了终结器）中定义的任何清理逻辑。

示例：`Person`对象`person1`被销毁，其内存由 GC 回收。  

</div>

---

<div>

## 实现专用、静态和嵌套类

实例构造函数用于指定在使用`new`运算符创建类的新实例时执行的代码。 当实例构造函数使用`public`访问修饰符时，可从应用程序中的任何其他代码访问生成的对象。 此类对对象及其成员的访问通常是可取的，但有时需要限制对类或类成员的访问。   
当需要隐藏或减少类的公开时，可以使用访问修饰符来控制类及其成员的可见性。

</div>

---

<div>

## 访问修饰符

所有类型和类型成员都具有可访问性级别，用于控制它们是否可从编译的应用程序中的其他代码（或其他程序集）访问。  直接在命名空间中声明的类可以具有`public`、`internal`或`file`访问权限。 如果未指定访问修饰符，则默认情况下会`internal`访问分配类。

使用以下访问修饰符在声明类型或成员时指定其可访问性：
- `public` ：任何程序集中的代码都可以访问此类型或成员。 包含类型的辅助功能级别控制该类型的公共成员的可访问性级别。
- `private`：只有在同一`class`或`struct`中声明的代码才能访问此成员。
- `protected`：只有同一`class`或派生`class`中的代码才能访问此类型或成员。
- `internal`：只有同一程序集中的代码才能访问此类型或成员。
- `protected internal`：只有同一程序集或另一程序集派生类中的代码才能访问此类型或成员。
- `private protected`：只有同一程序集和同一类或派生类中的代码才能访问类型或成员。
- `file`：只有同一文件中的代码可以访问类型或成员。

`record`类型的修饰符会导致编译器合成额外的成员。  
`record`修饰符不会影响`record class`或`record struct`的默认可访问性。

</div>

<div>

## 私有类构造函数

专用构造函数是一个特殊的实例构造函数。 专用构造函数通常用于仅包含静态成员的类。 如果类具有一个或多个私有构造函数，并且没有公共构造函数，则其他类（嵌套类除外）无法创建类的实例。 例如：

```
class NLog
{
    // Private Constructor:
    private NLog() { }

    public static double e = Math.E;  //2.71828...
}
```

空构造函数的声明可防止自动生成无参数构造函数。 如果未为构造函数指定访问修饰符，则默认为`private`。 但是，应使用`private`修饰符来阐明无法实例化类。

当没有实例字段或方法（例如 .NET 库中的`Math`类）或调用方法以获取类实例时，专用构造函数用于防止创建类的实例。 如果类中的所有方法都是静态的，请考虑将完整的类静态化。  
以下示例演示使用专用构造函数的类。

```
public class Counter
{
    private Counter() { }

    public static int currentCount;

    public static int IncrementCount()
    {
        return ++currentCount;
    }
}

class TestCounter
{
    static void Main()
    {
        // If you uncomment the following statement, it generates
        // an error because the constructor is inaccessible:
        // Counter aCounter = new Counter();   // Error

        Counter.currentCount = 100;
        Counter.IncrementCount();
        Console.WriteLine("New count: {0}", Counter.currentCount);

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output: New count: 101
```

如果从示例中取消注释以下语句，编译器将生成生成错误。 编译器了解私有构造函数不可访问。

```
// Counter aCounter = new Counter();   // Error
```

</div>

---

<div>

## 静态类

静态类基本上与非静态类相同，有一个重要区别：无法实例化静态类。 换句话说，不能使用`new`运算符从静态类创建变量。 虽然无法创建类的实例，但可以通过引用类名来访问静态类的成员。 例如，如果有一个名为`UtilityClass`的静态类具有名为`MethodA`的公共静态方法，则可以使用类和方法名称的组合调用该方法。 以下示例显示了此语法：

```
UtilityClass.MethodA();
```

静态类可用作对输入参数进行操作的方法的容器，无需`get`或`set`任何内部实例字段。  
例如，在 .NET 类库中，静态`System.Math`类包含执行数学运算的方法。 这些方法无需存储或检索对`Math`类的特定实例唯一的数据。 通过指定类名称和方法名称来调用类的成员，如以下示例所示：

```
double dub = -3.14;
Console.WriteLine(Math.Abs(dub));
Console.WriteLine(Math.Floor(dub));
Console.WriteLine(Math.Round(Math.Abs(dub)));

// Output:
// 3.14
// -4
// 3
```

与所有类类型一样，当加载引用该类的程序时，.NET 运行时会加载静态类的类型信息。 程序无法准确指定何时加载类。 但是，它保证加载并让其字段初始化，并在首次在程序中引用类之前调用其静态构造函数。 静态构造函数只调用一次，静态类在程序所在的应用程序域生存期内保留在内存中。

以下列表提供静态类的主要功能：
- 仅包含静态成员。
- 无法实例化。
- 密封。
- 不能包含实例构造函数。

因此，创建静态类基本上与创建仅包含静态成员和专用构造函数的类相同。 专用构造函数可防止类被实例化。 使用静态类的优点是编译器可以检查以确保不会意外添加实例成员。 编译器保证无法创建此类的实例。  
静态类是密封的，因此无法继承。 除了`Object`之外，它们不能继承自任何类或接口。 静态类不能包含实例构造函数。 但是，它们可以包含`static`构造函数。 如果类包含`static`需要非普通初始化的成员，则非静态类还应定义`static`构造函数。  
下面是一个静态类的示例，该类包含两种方法，该方法将温度从摄氏度转换为华氏度，从华氏度转换为摄氏度：

```
public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelsius)
    {
        // Convert argument to double for calculations.
        double celsius = Double.Parse(temperatureCelsius);

        // Convert Celsius to Fahrenheit.
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celsius.
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
}

class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celsius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celsius.");
        Console.Write(":");

        string? selection = Console.ReadLine();
        double F, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Please enter the Celsius temperature: ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;

            case "2":
                Console.Write("Please enter the Fahrenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                break;

            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
/* Example Output:
    Please select the convertor direction
    1. From Celsius to Fahrenheit.
    2. From Fahrenheit to Celsius.
    :2
    Please enter the Fahrenheit temperature: 20
    Temperature in Celsius: -6.67
    Press any key to exit.
 */
```

</div>

<div>

## 静态成员

非静态类可以包含静态方法、字段、属性或事件。 即使不存在该类的实例，静态成员也能在类上调用。 静态成员始终由类名而不是实例名称访问。 无论创建类的实例数如何，只有一个静态成员的副本存在。 静态方法和属性无法访问其包含类型的非静态字段和事件，并且无法访问任何对象的实例变量，除非它显式传入方法参数。  
声明具有一些静态成员的非静态类比将整个类声明为静态类更为典型。 静态字段的两种常见用途是保留实例化的对象数的计数，或存储必须在所有实例之间共享的值。  
静态方法可以重载，但不能重写，因为它们属于该类，并且不属于类的任何实例。  

虽然不能将字段声明为`static const`，但`const`字段在其行为中本质上是静态的。 它属于类型，不属于该类型的实例。 因此，可以使用用于静态字段的相同`const`表示法来访问`ClassName.MemberName`字段。 不需要任何对象实例。

```
public class Automobile
{
    public static int NumberOfWheels = 4;

    public static int SizeOfGasTank
    {
        get
        {
            return 15;
        }
    }

    public static void Drive() { }

    public static event EventType? RunOutOfGas;

    // Other nonstatic fields and properties...
}
```

在首次访问静态成员之前和静态构造函数（如果有）调用静态成员之前，将初始化静态成员。 若要访问静态类成员，请使用类的名称而不是变量名称来指定成员的位置，如以下示例所示：

```
Automobile.Drive();
int i = Automobile.NumberOfWheels;
```

如果类包含静态字段，请提供一个静态构造函数，用于在加载类时初始化它们。  
对静态方法的调用生成公共中间语言（CIL）的调用指令，而对实例方法的调用将生成一个`callvirt`指令，该指令还会检查 null 对象引用。 但是，在大多数情况下，两者之间的性能差异并不重要。

</div>

---

<div>

## 嵌套类

在另一个类中定义的`class`类型称为嵌套类。 例如：

```
public class Container
{
    class Nested
    {
        Nested() { }
    }
}
```

嵌套类的可访问性默认为`private`。
 这意味着嵌套类只能从其包含的类访问。 在前面的示例中，外部类型无法访问`Nested`类。

 可以指定访问修饰符来定义嵌套类型的可访问性，如下所示：
 - 类的嵌套类型可以是`public`、`protected`、`internal`、`protected internal`、`private`或`private protected`。

但是，在密封类中定义`protected`、`protected internal`或`private protected`嵌套类会生成编译器警告 CS0628，“在密封类中声明的新受保护成员”。  
**`注意`请注意，使嵌套类型在外部可见违反了代码质量规则 CA1034“嵌套类型不应可见”。**

以下示例将`Nested`类公开：

```
public class Container
{
    public class Nested
    {
        Nested() { }
    }
}
```

嵌套类或内部类可以访问包含类或外部类。 若要访问包含类，请将其作为参数传递给嵌套类的构造函数。 例如：

```
public class Container
{
    public class Nested
    {
        private Container? parent;

        public Nested()
        {
        }
        public Nested(Container parent)
        {
            this.parent = parent;
        }
    }
}
```

嵌套类有权访问其包含类可访问的所有成员。 它可以访问包含类的私有和受保护的成员，包括任何继承的受保护成员。

</div>

---

<div>

## 使用分部类实现类

可以将类或方法的定义拆分为两个或多个源文件。 每个源文件都包含类型或方法定义的一部分，所有部分在编译应用程序时合并。

</div>

<div>

## 分布类

在以下几种情况下需要拆分类定义：
- 通过单独的文件声明类可使多个程序员同时处理它。
- 可以将代码添加到类，而无需重新创建包含自动生成的源的源文件。 Visual Studio 在创建 Windows 窗体、Web 服务包装器代码等时使用此方法。 可以创建使用这些类的代码，而无需修改 Visual Studio 创建的文件。
- 源生成器可以在类中生成额外的功能。
要拆分类定义，请使用 `partial` 关键字修饰符。 实际上，每个分部类通常在单独的文件中定义，以便随着时间的推移更轻松地管理和扩展类。

```
// This is in Employee_Part1.cs
public partial class Employee
{
    public void DoWork()
    {
        Console.WriteLine("Employee is working.");
    }
}
```

```
// This is in Employee_Part2.cs
public partial class Employee
{
    public void GoToLunch()
    {
        Console.WriteLine("Employee is at lunch.");
    }
}
```

```
//Main program demonstrating the Employee class usage
public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.DoWork();
        emp.GoToLunch();
    }
}

// Expected Output:
// Employee is working.
// Employee is at lunch.
```

`partial` 关键字指示可以在命名空间中定义类的其他部分。 所有部分都必须使用 `partial` 关键字。 所有部分必须在编译时可用，才能形成最终类型。 所有部分必须具有相同的可访问性，例如 `public`、`private`等。

如果将任何部分声明为抽象，则整个类型被视为抽象。 如果将任何部分声明为密封，则整个类型被视为密封。 如果将任何部分声明为基类型，则整个类型将继承该类。

指定基类的所有部分都必须相同，但省略基类的部分仍继承基类型。 部分可以指定不同的基接口，最终类型实现所有分部声明列出的所有接口。 在分部定义中声明的任何类、结构或接口成员都可用于所有其他部分。 最终类型是编译时所有部分的组合。

`注意`委托或枚举声明上不提供`partial`修饰符。

下面的示例演示了嵌套的类型可以是分部类型，即使嵌套在其中的类型本身不是分部类型。

```
class Container
{
    partial class Nested
    {
        void Test() { }
    }

    partial class Nested
    {
        void Test2() { }
    }
}
```

在编译时，将合并分部类型定义的特性。 例如，请考虑以下声明：

```
[SerializableAttribute]
partial class Moon { }

[ObsoleteAttribute]
partial class Moon { }
```

它们等效于以下声明：

```
[SerializableAttribute]
[ObsoleteAttribute]
class Moon { }
```

以下是从所有分部类型定义合并的：

- XML 注释。 但是，如果部分成员的两个声明都包含注释，则仅包括实现成员的注释。
- 接口
- 泛型类型参数特性
- 类特性
- 成员
示例： 

```
partial class Earth : Planet, IRotate { }
partial class Earth : IRevolve { }
```

它们等效于以下声明：

```
class Earth : Planet, IRotate, IRevolve { }
```

</div>

<div>

## 对分部类定义的限制

使用分部类定义时，需要遵循以下几个规则：
- 所有分部类型定义要求同一类型的部分必须使用 partial 修改。 例如，以下类声明生成错误：  
    public partial class A { }
    //public class A { }  // Error, must also be marked partial
- `partial` 修饰符只能出现在关键字 `class`、`struct` 或 `interface` 之前。
- 在分部类型定义中允许嵌套分部类型，如以下示例所示：
```
partial class ClassWithNestedClass
{
    partial class NestedClass { }
}

partial class ClassWithNestedClass
{
    partial class NestedClass { }
}
```
- 所有分部类型定义要求同一类型的部分都必须在同一程序集和同一模块（.exe 或 .dll 文件）中定义。 分部定义不能跨越多个模块。
- 类名和泛型类型参数必须匹配所有分部类型定义。 泛型类型可以是分部类型。 每个分部声明必须按相同顺序使用相同的参数名称。
- 分部类型定义的以下关键字是可选的，但如果在一个分部类型定义上存在，则必须在同一类型的其他分部定义上指定相同的关键字：
  - public
  - 专用
  - protected
  - 内部
  - abstract
  - 密封
  - 基类
  - new 修饰符（嵌套部分）
  - 泛型约束

</div>

<div>

## 实现分部类

在下面的示例中，`Coords`类的字段和构造函数在一个分部类定义 (`Coords_Part1.cs`) 中声明，`PrintCoords`方法在另一个分部类定义 (`Coords_Part2.cs`) 中声明。 这种分离演示了如何跨多个文件划分分部类，以便更轻松地保持可维护性。

```
// This is in Coords_Part1.cs
 public partial class Coords
 {
     private int x;
     private int y;

     public Coords(int x, int y)
     {
         this.x = x;
         this.y = y;
     }
 }

 // This is in Coords_Part2.cs
 public partial class Coords
 {
     public void PrintCoords()
     {
         Console.WriteLine("Coords: {0},{1}", x, y);
     }
 }

// Main program demonstrating the Coords class usage
 class TestCoords
 {
     static void Main()
     {
         Coords myCoords = new Coords(10, 15);
         myCoords.PrintCoords();

         // Keep the console window open in debug mode.
         Console.WriteLine("Press any key to exit.");
         Console.ReadKey();
     }
 }
 // Output: Coords: 10,15
```

</div>

<div>

## 分布成员

分部类可以包含分部成员。 类的一部分包含成员的签名。 可以在同一部分或另一部分中定义实现。  
当签名遵循以下规则时，分部方法不需要实现：
- 声明不包含任何访问修饰符。 默认情况下，该方法具有专用访问。
- 返回类型为`void`。
- 没有任何参数具有`out`修饰符。
- 方法声明不能包括以下任何修饰符：
  - virtual
  - 替代
  - 密封
  - new
  - extern

当没有实现时，该方法和对方法的所有调用都将在编译时移除。  
任何不符合所有这些限制的方法（包括属性和索引器）都必须提供实现。 该实现可能由源生成器提供。 不能使用自动实现的属性实现分部属性。 编译程序无法区分自动实现的属性和分部属性的声明。

从 C# 13 开始，分部属性的实现声明可以使用字段支持的属性来定义实现声明。 字段支持的属性提供简洁的语法，其中 field 关键字访问该属性的编译程序合成支持字段。 例如，可以编写以下代码：

```
// in file1.cs
public partial class PropertyBag
{
    // Defining declaration
    public partial int MyProperty { get; set; }
}

// In file2.cs
public partial class PropertyBag
{
    // Defining declaration
    public partial int MyProperty { get => field; set; }
}
```

可以在`field`或`get`访问器中使用`set`，也可以同时使用两者。  
**重要`field`关键字是 C# 13 中的预览功能。 必须使用 .NET 9，并将`<LangVersion>`元素设置为在项目文件中预览，才能使用`field`上下文关键字。**

应小心在具有名为`field`的字段的类中使用`field`关键字功能。 新的`field`关键字在属性访问器的范围内隐藏一个名为`field`的字段。 可以更改字段变量的名称，也可以使用`@`令牌将字段标识符引用为`@field`。

分部方法使类的一个部分的实现者能够声明成员。 类的另一部分的实现者可以定义该成员。 这种分离在两种情况下很有用：生成样板代码的模板和源生成器。
- 模板代码：模板保留方法名称和签名，以便生成的代码可以调用该方法。 这些方法遵循限制，使开发人员能够决定是否实现该方法。 如果未实现该方法，则编译程序将移除方法签名和对该方法的所有调用。 对该方法的调用（包括调用中对自变量的评估所产生的任何结果）在运行时不起作用。 因此，即使未提供实现，分部类中的任何代码都可以自由使用分部方法。 如果调用方法但不实现，则不会生成编译时或运行时错误。
- 源生成器：源生成器为成员提供实现。 人类开发人员可以添加成员声明（通常是由源生成器读取的特性）。 开发人员可以编写调用这些成员的代码。 源生成器在编译期间运行，并提供实现。 在这种情况下，不遵循通常可能未实现的分部成员的限制。
```
// Definition in file1.cs
partial void OnNameChanged();

// Implementation in file2.cs
partial void OnNameChanged()
{
  // method body
}
```
- 分部成员声明必须以上下文关键字 `partial` 开头。
- 分部类型的两个部分中的分部成员签名必须匹配。
- 分部成员可以具有 `static` 和 `unsafe` 修饰符。
- 分部成员可以是泛型成员。 约束在定义和实现方法声明上必须相同。 参数和类型参数名称在实现声明中不必与定义参数名称相同。
- 可以对定义和实现的分部方法进行委托，但不能对没有实现的分部方法进行委托。
</div>

---

<div>

## 指定命名和可选方法参数

命名参数使你可以通过将参数与其名称匹配而不是参数列表中的位置来指定参数的参数。 可选参数使你可以省略某些参数的参数。 这两种技术都可用于方法、索引器、构造函数和委托。

使用命名参数和可选参数时，参数的计算顺序为参数列表中出现的顺序，而不是参数列表。

通过命名参数和可选参数，可为所选参数提供参数。 此功能极大地简化了对 COM 接口（如 Microsoft Office 自动化 API）的调用。

</div>

## 命名参数

命名参数使你能够将参数顺序与所调用方法的参数列表中的参数顺序匹配。 每个参数的参数都可以由参数名称指定。
**`注意`命名参数通过标识每个参数表示的内容来提高代码的可读性。**  
请考虑使用以下方法签名的方法：

```
static void PrintOrderDetails(string sellerName, int orderNum, string productName)
{
    // Code to print the order details
}
```

只要参数按正确的顺序（方法签名定义），就可以成功调用此方法，而无需使用命名参数：

```
PrintOrderDetails("Gift Shop", 31, "Red Mug");
```

如果不记得参数的顺序，但知道参数的名称，则可以按任意顺序发送参数。

```
PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
```

与位置参数一起使用时，只要命名参数在正确的位置使用，命名参数就有效。  
下面的示例正常工作，因为：参数`productName`显式命名，后跟任何位置参数，并且处于正确的位置。

```
PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
```

任何无序命名参数后面的位置参数无效。

```
// This generates CS1738: Named argument specifications must appear after all fixed arguments have been specified.
PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
```

</div>

<div>

## 可选参数

方法定义可以指定其参数是必需参数还是可选参数。 任何调用都必须为所有必需的参数提供参数，但可以省略可选参数的参数。 可以为 `null` 的引用类型（`T?`）允许参数显式`null`，但本质上不使参数可选。

每个可选参数都有一个默认值作为其定义的一部分。 如果未为该参数发送任何参数，则使用默认值。 默认值必须是下列类型的表达式之一：
- 常量表达式，如文本字符串或数字。
- 窗体`new ValType()`的表达式，其中`ValType`是值类型，例如`enum`或`struct`。
- 窗体`default(ValType)`的表达式，其中`ValType`是值类型。

可选参数在参数列表的末尾定义，并在任何必需的参数之后定义。 调用方必须为所有必需的参数和它指定的参数前面的任何可选参数提供参数。 参数列表中的逗号分隔间隙不受支持。 例如，在以下代码中，实例方法`ExampleMethod`使用一个必需参数和两个可选参数定义。

```
public void ExampleMethod(int required, string optionalstr = "default string", int optionalint = 10)
```

对`ExampleMethod`的以下调用会导致编译器错误，因为第三个参数提供了参数，而不是第二个参数。

```
// anExample.ExampleMethod(3, ,4);
```

但是，如果知道第三个参数的名称，则可以使用命名参数来完成任务。

```
anExample.ExampleMethod(3, optionalint: 4);
```

`注意`还可以使用 .NET`OptionalAttribute`类声明可选参数。`OptionalAttribute`参数不需要默认值。 但是，如果需要默认值，请考虑使用`DefaultParameterValueAttribute`类。

在下面示例中， `ExampleClass` 的构造函数有一个参数，这是可选的。 实例方法 `ExampleMethod` 具有一个必需的参数、 `required` 和两个可选参数， `optionalstr` 和 `optionalint` 。  `Main` 中的代码显示了可以调用构造函数和方法的不同方式。

```
namespace OptionalNamespace
{
    class OptionalExample
    {
        static void Main(string[] args)
        {
            // Instance anExample does not send an argument for the constructor's
            // optional parameter.
            ExampleClass anExample = new ExampleClass();
            anExample.ExampleMethod(1, "One", 1);
            anExample.ExampleMethod(2, "Two");
            anExample.ExampleMethod(3);

            // Instance anotherExample sends an argument for the constructor's
            // optional parameter.
            ExampleClass anotherExample = new ExampleClass("Provided name");
            anotherExample.ExampleMethod(1, "One", 1);
            anotherExample.ExampleMethod(2, "Two");
            anotherExample.ExampleMethod(3);

            // The following statements produce compiler errors.

            // An argument must be supplied for the first parameter, and it
            // must be an integer.
            //anExample.ExampleMethod("One", 1);
            //anExample.ExampleMethod();

            // You can't leave a gap in the provided arguments.
            //anExample.ExampleMethod(3, ,4);
            //anExample.ExampleMethod(3, 4);

            // You can use a named parameter to make the previous
            // statement work.
            anExample.ExampleMethod(3, optionalint: 4);
        }
    }

    class ExampleClass
    {
        private string _name;

        // Because the parameter for the constructor, name, has a default
        // value assigned to it, it's optional.
        public ExampleClass(string name = "Default name")
        {
            _name = name;
        }

        // The first parameter, required, has no default value assigned
        // to it. Therefore, it isn't optional. Both optionalstr and
        // optionalint have default values assigned to them. They're optional.
        public void ExampleMethod(int required, string optionalstr = "default string",
            int optionalint = 10)
        {
            Console.WriteLine(
                $"{_name}: {required}, {optionalstr}, and {optionalint}.");
        }
    }

    // The output from this example is the following:
    // Default name: 1, One, and 1.
    // Default name: 2, Two, and 10.
    // Default name: 3, default string, and 10.
    // Provided name: 1, One, and 1.
    // Provided name: 2, Two, and 10.
    // Provided name: 3, default string, and 10.
    // Default name: 3, default string, and 4.
}
```

</div>

<div>

## 命名参数和可选参数的重载解析

重载的方法是具有相同名称但不同的签名的方法。 方法的签名由方法的名称及其每个形式参数的类型和类型（值、引用或输出）组成。 重载解析是选择在多个具有相同名称但不同签名的方法之间调用的最佳方法的过程。  
命名参数和可选参数的使用通过以下方式影响重载解析：
- 如果每个参数都是可选的，或者按名称或按位置对应于调用语句中的单个参数，并且该参数可以转换为参数的类型，则方法是一种候选执行方法。
- 如果找到多个候选项，则首选转换的重载解析规则将应用于显式指定的参数。 忽略可选参数的省略参数。
- 如果两个候选参数被判断为同样良好，则首选项将转到没有可选参数的候选项，该参数在调用中省略了参数。 重载解析通常首选参数较少的候选项。

</div>

---

<div>

## 使用初始值设定项和复制构造函数实例化对象

对象初始值设定项和复制构造函数是实例化 C# 中的对象的两种方法。 对象初始值设定项允许在创建时将值分配给对象的任何可访问字段或属性，而无需调用构造函数后跟赋值语句行。 复制构造函数允许通过复制现有对象的值来创建新对象。

### 对象初始值设定项

对象初始值设定项允许在创建时将值分配给对象的任何可访问字段或属性，而无需调用构造函数后跟赋值语句行。 使用对象初始值设定项语法可以指定构造函数的参数或省略参数（和括号语法）。  
可以使用对象初始值设定项以声明性方式初始化类型对象，而无需显式调用类型的构造函数。  
编译器首先访问无参数实例构造函数，然后处理成员初始化来处理对象初始值设定项。 因此，如果无参数构造函数在类中声明为私有构造函数，则需要公共访问的对象初始值设定项将失败。

下面示例将演示如何使用对象初始值设定项。

第一个代码示例显示名为`Cat的类的类定义。 定义包括两个构造函数，其中一个是无参数构造函数。 第二个代码示例演示如何使用对象初始值设定项实例化`Cat`对象。 对象初始值设定项将值分配给`Age`对象的`Name`和`Cat`属性。

```
public class Cat
{
    // Automatically implemented properties.
    public int Age { get; set; }
    public string? Name { get; set; }

    public Cat()
    {
    }

    public Cat(string name)
    {
        this.Name = name;
    }
}
```

```
public class Program
{
    public static void Main()
    {
        // Declare and instantiate a new Cat object by using an object initializer.
        Cat cat = new Cat { Age = 10, Name = "Fluffy" };

        // Declare and instantiate a new Cat object by using an object initializer.
        Cat sameCat = new Cat("Fluffy") { Age = 10 };
    }
}
```

下面是另一个示例，演示如何使用对象初始值设定项初始化新的`StudentName`类型。 此示例设置`StudentName`类型中的属性：

```
public class HowToObjectInitializers
{
    public static void Main()
    {
        // Declare a StudentName by using the constructor that has two parameters.
        StudentName student1 = new StudentName("Lisa", "Yeh");

        // Make the same declaration by using an object initializer and sending
        // arguments for the first and last names. The parameterless constructor is
        // invoked in processing this declaration, not the constructor that has
        // two parameters.
        StudentName student2 = new StudentName
        {
            FirstName = "Sandy",
            LastName = "Zoeng"
        };

        // Declare a StudentName by using an object initializer and sending
        // an argument for only the ID property. No corresponding constructor is
        // necessary. Only the parameterless constructor is used to process object
        // initializers.
        StudentName student3 = new StudentName
        {
            ID = 183
        };

        // Declare a StudentName by using an object initializer and sending
        // arguments for all three properties. No corresponding constructor is
        // defined in the class.
        StudentName student4 = new StudentName
        {
            FirstName = "Thomas",
            LastName = "Margand",
            ID = 116
        };

        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());
        Console.WriteLine(student3.ToString());
        Console.WriteLine(student4.ToString());
    }
    // Output:
    // Lisa  0
    // Sandy  0
    //   183
    // Thomas  116

    public class StudentName
    {
        // This constructor has no parameters. The parameterless constructor
        // is invoked in the processing of object initializers.
        // You can test this by changing the access modifier from public to
        // private. The declarations in Main that use object initializers will
        // fail.
        public StudentName() { }

        // The following constructor has parameters for two of the three
        // properties.
        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        // Properties.
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ID { get; set; }

        // Override the ToString method of the Object class.
        public override string ToString() => FirstName + "  " + ID;
    }
}
```

通过对象初始值设定项语法，可以创建一个实例，并在该实例之后将新创建的对象及其分配的属性分配给赋值中的变量。  
除了分配字段和属性之外，对象初始值设定项还可以设置索引器。 请考虑以下基本`Matrix`类：

```
public class Matrix
{
    private double[,] storage = new double[3, 3];

    public double this[int row, int column]
    {
        // The embedded array will throw out of range exceptions as appropriate.
        get { return storage[row, column]; }
        set { storage[row, column] = value; }
    }
}
```

可以使用以下代码初始化标识矩阵：

```
var identity = new Matrix
{
    [0, 0] = 1.0,
    [0, 1] = 0.0,
    [0, 2] = 0.0,

    [1, 0] = 0.0,
    [1, 1] = 1.0,
    [1, 2] = 0.0,

    [2, 0] = 0.0,
    [2, 1] = 0.0,
    [2, 2] = 1.0,
};
```

以下示例定义一个`BaseballTeam`类，该类使用索引器获取和设置位于不同位置的玩家。 初始值设定项可以根据位置的缩写或棒球记分卡上每个位置使用的编号来分配玩家：

```
public class HowToIndexInitializer
{
    public class BaseballTeam
    {
        private string[] players = new string[9];
        private readonly List<string> positionAbbreviations = new List<string>
        {
            "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
        };

        public string this[int position]
        {
            // Baseball positions are 1 - 9.
            get { return players[position-1]; }
            set { players[position-1] = value; }
        }
        public string this[string position]
        {
            get { return players[positionAbbreviations.IndexOf(position)]; }
            set { players[positionAbbreviations.IndexOf(position)] = value; }
        }
    }

    public static void Main()
    {
        var team = new BaseballTeam
        {
            ["RF"] = "Lisa Yeh",
            [4] = "Sandy Zoeng",
            ["CF"] = "Thomas Margand"
        };

        Console.WriteLine(team["2B"]);
    }
}
```

#### 具有所需修饰符的对象初始值设定项

使用必需的关键字强制调用方使用对象初始值设定项设置属性或字段的值。 不需要将所需的属性设置为构造函数参数。 编译器可确保所有调用方初始化这些值。

```
// The `FirstName` property is optional and has a default value of an empty string.        
// The `LastName` property is required and must be initialized during object creation.
// You can create a new instance of the Person class using both properties.
var friend1 = new Person() { FirstName = "Lisa", LastName = "Yeh" };
Console.WriteLine($"Hello, {friend1.FirstName} {friend1.LastName}!");

// You can create a new instance of the Person class using only the LastName property.
var friend2 = new Person() { LastName = "Yeh"};
Console.WriteLine($"Hello, {friend2.FirstName} {friend2.LastName}!");

// You can assign a different value to the properties after the object is created.
friend2.FirstName = "Sandy";
friend2.LastName = "Chen";
Console.WriteLine($"Hello, {friend2.FirstName} {friend2.LastName}!");

// Compiler error: Required property 'LastName' must be initialized.
//var friend3 = new Person() { FirstName = "Lisa"};
//var friend4 = new Person();

// Output:
// Hello, Lisa Yeh!
// Hello,  Yeh!
// Hello, Sandy Chen!

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; }

}
```

这是一种典型的做法，可以保证正确初始化对象，尤其是在有多个字段或属性要管理和不希望将它们全部包含在构造函数中时。

#### 具有 init 访问器的对象初始值设定项

确保没有人可以使用 init 访问器来限制设计对象。 它有助于限制属性值的设置。

```
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; init; }
}

// You can create a new instance of the Person class any combination of the properties.
var friend0 = new Person();
var friend1 = new Person() { FirstName = "Lisa" };
var friend2 = new Person() { LastName = "Yeh" };
var friend3 = new Person() { FirstName = "Lisa", LastName = "Yeh" };

Console.WriteLine($"Hello, {friend0.FirstName} {friend0.LastName}!");
Console.WriteLine($"Hello, {friend1.FirstName} {friend1.LastName}!");
Console.WriteLine($"Hello, {friend2.FirstName} {friend2.LastName}!");
Console.WriteLine($"Hello, {friend3.FirstName} {friend3.LastName}!");

// You can assign a different value to the FirstName property after the object is created, but not the LastName property.
friend3.FirstName = "Sandy";

// Compiler error:
// Error CS8852  Init - only property or indexer 'Person.LastName' can only be assigned in an object initializer,
//               or on 'this' or 'base' in an instance constructor or an 'init' accessor.
//friend3.LastName = "Chen";

Console.WriteLine($"Hello, {friend3.FirstName} {friend3.LastName}!");


// Output:
// Hello,  unknown!
// Hello, Lisa unknown!
// Hello,  Yeh!
// Hello, Lisa Yeh!
// Hello, Sandy Yeh!
```

必需的仅初始化属性支持不可变结构，同时允许类型用户使用自然语法。

#### 具有类类型属性的对象初始值设定项

在初始化对象时，必须考虑类类型属性的含义：

```
public class HowToClassTypedInitializer
{
    public class EmbeddedClassTypeA
    {
        public int I { get; set; }
        public bool B { get; set; }
        public string S { get; set; }
        public EmbeddedClassTypeB ClassB { get; set; }

        public override string ToString() => $"{I}|{B}|{S}|||{ClassB}";

        public EmbeddedClassTypeA()
        {
            Console.WriteLine($"Entering EmbeddedClassTypeA constructor. Values are: {this}");
            I = 3;
            B = true;
            S = "abc";
            ClassB = new() { BB = true, BI = 43 };
            Console.WriteLine($"Exiting EmbeddedClassTypeA constructor. Values are: {this})");
        }
    }

    public class EmbeddedClassTypeB
    {
        public int BI { get; set; }
        public bool BB { get; set; }
        public string BS { get; set; }

        public override string ToString() => $"{BI}|{BB}|{BS}";

        public EmbeddedClassTypeB()
        {
            Console.WriteLine($"Entering EmbeddedClassTypeB constructor. Values are: {this}");
            BI = 23;
            BB = false;
            BS = "BBBabc";
            Console.WriteLine($"Exiting EmbeddedClassTypeB constructor. Values are: {this})");
        }
    }

    public static void Main()
    {
        var a = new EmbeddedClassTypeA
        {
            I = 103,
            B = false,
            ClassB = { BI = 100003 }
        };
        Console.WriteLine($"After initializing EmbeddedClassTypeA: {a}");

        var a2 = new EmbeddedClassTypeA
        {
            I = 103,
            B = false,
            ClassB = new() { BI = 100003 } //New instance
        };
        Console.WriteLine($"After initializing EmbeddedClassTypeA a2: {a2}");
    }

    // Output:
    //Entering EmbeddedClassTypeA constructor Values are: 0|False||||
    //Entering EmbeddedClassTypeB constructor Values are: 0|False|
    //Exiting EmbeddedClassTypeB constructor Values are: 23|False|BBBabc)
    //Exiting EmbeddedClassTypeA constructor Values are: 3|True|abc|||43|True|BBBabc)
    //After initializing EmbeddedClassTypeA: 103|False|abc|||100003|True|BBBabc
    //Entering EmbeddedClassTypeA constructor Values are: 0|False||||
    //Entering EmbeddedClassTypeB constructor Values are: 0|False|
    //Exiting EmbeddedClassTypeB constructor Values are: 23|False|BBBabc)
    //Exiting EmbeddedClassTypeA constructor Values are: 3|True|abc|||43|True|BBBabc)
    //Entering EmbeddedClassTypeB constructor Values are: 0|False|
    //Exiting EmbeddedClassTypeB constructor Values are: 23|False|BBBabc)
    //After initializing EmbeddedClassTypeA a2: 103|False|abc|||100003|False|BBBabc
}
```

下一个示例演示使用包含和不使用参数的构造函数执行构造函数和成员初始化的顺序：

```
public class ObjectInitializersExecutionOrder
{
    public static void Main()
    {
        new Person { FirstName = "Lisa", LastName = "Yeh", City = "unknown" };
        new Dog(2) { Name = "Oscar" };
    }

    public class Dog
    {
        private int age;
        private string name;

        public Dog(int age)
        {
            Console.WriteLine("Hello from Dog's non-parameterless constructor");
            this.age = age;
        }

        public required string Name
        {
            get { return name; }

            set
            {
                Console.WriteLine("Hello from setter of Dog's required property 'Name'");
                name = value;
            }
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private string city;

        public Person()
        {
            Console.WriteLine("Hello from Person's parameterless constructor");
        }

        public required string FirstName
        {
            get { return firstName; }

            set
            {
                Console.WriteLine("Hello from setter of Person's required property 'FirstName'");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }

            init
            {
                Console.WriteLine("Hello from setter of Person's init property 'LastName'");
                lastName = value;
            }
        }

        public string City
        {
            get { return city; }

            set
            {
                Console.WriteLine("Hello from setter of Person's property 'City'");
                city = value;
            }
        }
    }

    // Output:
    // Hello from Person's parameterless constructor
    // Hello from setter of Person's required property 'FirstName'
    // Hello from setter of Person's init property 'LastName'
    // Hello from setter of Person's property 'City'
    // Hello from Dog's non-parameterless constructor
    // Hello from setter of Dog's required property 'Name'
}
```

### 复制构造函数

在下面的示例中，`Person`类定义复制构造函数，该构造函数采用其参数作为`Person`实例。 参数的属性值分配给`Person`的新实例的属性。 该代码包含一个备用复制构造函数，该构造函数发送要复制到类的实例构造函数的`Name`和`Age`属性。

`Person`类是密封的，因此无法声明派生类型，仅复制基类可能会引发错误。

```
public sealed class Person
{
    // Copy constructor.
    public Person(Person previousPerson)
    {
        Name = previousPerson.Name;
        Age = previousPerson.Age;
    }

    //// Alternate copy constructor calls the instance constructor.
    //public Person(Person previousPerson)
    //    : this(previousPerson.Name, previousPerson.Age)
    //{
    //}

    // Instance constructor.
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int Age { get; set; }

    public string Name { get; set; }

    public string Details()
    {
        return Name + " is " + Age.ToString();
    }
}

class TestPerson
{
    static void Main()
    {
        // Create a Person object by using the instance constructor.
        Person person1 = new Person("Lisa", 40);

        // Create another Person object, copying person1.
        Person person2 = new Person(person1);

        // Change each person's age.
        person1.Age = 39;
        person2.Age = 41;

        // Change person2's name.
        person2.Name = "Sandy";

        // Show details to verify that the name and age fields are distinct.
        Console.WriteLine(person1.Details());
        Console.WriteLine(person2.Details());

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output:
// Lisa is 39
// Sandy is 41
```

</div>

---

<div>

## 检查类终结器

终结器（以前称为析构函数）用于在垃圾回收器（GC）收集类实例时执行任何必要的最终清理。 在大多数情况下，可以通过使用`System.Runtime.InteropServices.SafeHandle`或派生类来包装任何非托管句柄来避免编写终结器。  
使用终结器时要记住的一些事项：
- 无法在`struct`类型中定义终结器。 它们仅用于类。
- 类只能有一个终结器。
- 无法继承或重载终结器。
- 无法调用终结器。 它们会自动调用。
- 终结器不采用修饰符或具有参数。
## 终结器语法

在 C# 中，终结器使用波形符（`~`）定义，后跟类名。 它不采用任何参数，并且无法显式调用。

```
class Car
{
    ~Car()  // finalizer
    {
        // cleanup statements...
    }
}
```

还可以将终结器实现为表达式正文定义，如以下示例所示。

```
public class Destroyer
{
   public override string ToString() => GetType().Name;

   ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
}
```

### 垃圾回收与终结器之间的关系

.NET 中的垃圾回收器会自动管理托管对象的内存分配和释放。 不再引用对象时，GC 会将其标记为集合，并最终回收其内存。 如果类具有终结器，GC 会在回收对象的内存之前调用终结器。 终结器允许该对象释放它保留的任何非托管资源。  
最终化过程通常涉及以下步骤：
- 当 GC 检测到具有终结器的对象不再可访问时，它会将对象移动到最终化队列。
- 终结器线程执行终结器方法。
- 完成器运行后，该对象将移动到 GC 的`freachable`队列，该队列在下一个 GC 周期中有资格进行垃圾回收。

### 终结器示例

```
public class ResourceHolder
{
    // Unmanaged resource
    private IntPtr unmanagedResource;

    // Constructor
    public ResourceHolder()
    {
        // Allocate unmanaged resource
        unmanagedResource = /* allocate resource */;
    }

    // Finalizer
    ~ResourceHolder()
    {
        // Release unmanaged resource
        if (unmanagedResource != IntPtr.Zero)
        {
            // Free the resource
            /* free resource */
            unmanagedResource = IntPtr.Zero;
        }
    }
}
```

## 使用终结器实现释放模式

`IDisposable`和`IAsyncDisposable`等接口用于确定性地释放资源。 显式调用`Dispose`方法以释放资源，而终结器充当安全网，以确保即使未调用`Dispose`，也会释放资源。  
使用终结器时，请记住以下几点：
- 终结器是不确定的，这意味着无法预测终结器何时运行。 这取决于 GC 的计划。 此行为可能会导致释放非托管资源时出现延迟。
- 终结器可能会影响性能，因为具有终结器的对象需要更长的时间才能收集。
- 建议实现`IDisposable`接口和用于确定性资源清理的`Dispose`方法。 可以显式调用`Dispose`方法以释放资源，终结器可用作安全网。

示例

```
public class ResourceHolder : IDisposable
{
    // Unmanaged resource
    private IntPtr unmanagedResource;
    private bool disposed = false;

    // Constructor
    public ResourceHolder()
    {
        // Allocate unmanaged resource
        unmanagedResource = /* allocate resource */;
    }

    // Dispose method
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Free other managed objects
            }

            // Free unmanaged resources
            if (unmanagedResource != IntPtr.Zero)
            {
                /* free resource */
                unmanagedResource = IntPtr.Zero;
            }

            disposed = true;
        }
    }

    // Finalizer
    ~ResourceHolder()
    {
        Dispose(false);
    }
}
```

在上面示例中：
- 调用`Dispose`方法以确定方式释放资源。
- 如果未调用`Dispose(false)`，终结器将调用`Dispose`以释放非托管资源。
- 如果已调用`GC.SuppressFinalize(this)`，则`Dispose`用于防止终结器运行。

</div>

---

