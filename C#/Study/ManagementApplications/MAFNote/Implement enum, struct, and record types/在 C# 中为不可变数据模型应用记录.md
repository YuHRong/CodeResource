# 在 C# 中为不可变数据模型应用记录

## 目录在这里

- [在 C# 中为不可变数据模型应用记录](#在-c-中为不可变数据模型应用记录)
  - [目录在这里](#目录在这里)
  - [定义不可变数据模型的记录](#定义不可变数据模型的记录)
  - [将记录与类和结构进行比较](#将记录与类和结构进行比较)
  - [使用记录实现相等性检查](#使用记录实现相等性检查)
  - [使用位置语法定义记录](#使用位置语法定义记录)
  - [对记录应用继承](#对记录应用继承)
  - [实际示例：使用记录来表示库存系统中的产品](#实际示例使用记录来表示库存系统中的产品)

想象一下，你正在参与一个项目，需要为那些创建后就不应再更改的数据建模，例如人的姓名或产品的详细信息。  
C# 中的记录提供了一种创建不可变数据模型和基于值相等性的方法，使它们非常适合此类方案。

## 定义不可变数据模型的记录

要定义不可变数据模型，请使用`record`关键字。 记录自动生成属性、构造函数和方法，例如`ToString`，`Equals`和`GetHashCode`

```c#
public record Person(string FirstName, string LastName);
```

代码示例演示如何使用不可变属性定义记录。  
在此示例中：
- `FirstName`和`LastName`是定义不可变属性的位置参数。
- 编译器生成主构造函数和仅初始化属性。

记录在诸如对 API 响应、配置设置或日志事件进行建模等场景中非常有用，因为这些场景下不可变性和简洁性至关重要。

## 将记录与类和结构进行比较

记录与类和结构在多个方面存在差异：
- 不可变性<br>：默认情况下，记录是不可变的，而类和结构需要更多努力来强制实现不可变性。
- 相等性<br>：记录使用基于值的相等性，而类则使用引用相等性，而结构依赖于值相等性，但没有编译器合成的方法。
- 继承<br>：记录类支持继承，但记录结构不支持。

| 功能/特点 | 记录类 | 记录结构 | 类型     | 结构   |
| --------- | ------ | -------- | -------- | ------ |
| 不可变性  | 违约   | 可选     | 可选     | 可选   |
| 平等      | 基于值 | 基于值   | 基于引用 | 基于值 |
| 继承      | 支持   | 不支持   | 支持     | 不支持 |

上表汇总了记录、类和结构之间的主要差异。

*提示*如果需要具有基于值相等性的不可变数据模型，请使用记录。 对于可变类型或以行为为中心的类型，请考虑改用类。

## 使用记录实现相等性检查

记录提供基于值的内置相等性。 如果两个记录实例的类型和属性值匹配，则被视为相等。

```c#
var person1 = new Person("Chris", "Kuo");
var person2 = new Person("Chris", "Kuo");
Console.WriteLine(person1 == person2); // Output: True
```

代码示例演示如何记录使用基于值的相等性来比较实例。

还可以通过重写`Equals`或`GetHashCode`方法来自定义相等性行为。 例如：

```c#
public record Product(string Name, decimal Price)
{
    public override int GetHashCode() => HashCode.Combine(Name.ToLower(), Price);
}
```

代码示例演示如何自定义记录中的相等行为。

## 使用位置语法定义记录

使用位置语法可以简明地定义记录。 编译程序生成属性、主构造函数和析构函数。

```c#
public record Point(int X, int Y);

var point = new Point(3, 4); 
Console.WriteLine(point); // Output: Point { X = 3, Y = 4 }
```

代码示例演示如何使用位置语法定义记录。  
此方法通过减少样本代码简化了不可变数据模型的创建。

## 对记录应用继承

记录类支持继承，使你可以创建层次结构，同时保持不可变性和基于值的相等性。

```c#
public record Animal(string Name);
public record Dog(string Name, string Breed) : Animal(Name);

var dog = new Dog("Buddy", "Golden Retriever");
Console.WriteLine(dog); // Output: Dog { Name = Buddy, Breed = Golden Retriever }
```

代码示例演示如何对记录类使用继承。

继承可用于创建相关数据模型的层次结构，例如动物、车辆或用户角色。

*注意*记录不能从类继承，而类不能从记录继承。

## 实际示例：使用记录来表示库存系统中的产品

记录非常适合表示不可变数据。 例如，可以使用记录来表示库存系统中的产品，并比较两个产品：

```c#
public record Product(string Name, decimal Price);

var product1 = new Product("Laptop", 1200m);
var product2 = new Product("Laptop", 1200m);
var product3 = new Product("Tablet", 600m);

Console.WriteLine($"Are product1 and product2 equal? {product1 == product2}");
Console.WriteLine($"Are product1 and product3 equal? {product1 == product3}");
```

此示例演示如何为产品定义记录、创建记录的实例，以及如何使用基于值的相等性对其进行比较。

结合不可变性、基于值的相等性和简洁语法，记录提供了一种在 C# 中为数据建模的强大方法。 这些功能使记录非常适合数据完整性和简单性至关重要的方案。

