# 用枚举表示 C#中的命名常量

## 目录在这里

- [用枚举表示 C#中的命名常量](#用枚举表示-c中的命名常量)
  - [目录在这里](#目录在这里)
  - [描述枚举和枚举值的方案](#描述枚举和枚举值的方案)
  - [定义枚举](#定义枚举)
  - [为枚举设置基础类型和值](#为枚举设置基础类型和值)
  - [使用枚举执行转换](#使用枚举执行转换)
  - [应用用于设计枚举的最佳做法](#应用用于设计枚举的最佳做法)
  - [使用自定义值和方法实现枚举](#使用自定义值和方法实现枚举)
  - [示例：使用枚举管理订单状态](#示例使用枚举管理订单状态)

想象你正在开发一个跟踪订单状态的项目，需要以清晰且易于管理的方式组织诸如“待处理”、“已发货”或“已送达”等值。  
在 C#中使用枚举可以让你创建这些订单状态列表。
使用枚举可以让你在项目中更轻松地使用这些状态，而无需重复创建或查找它们。

## 描述枚举和枚举值的方案

枚举类型非常适合表示一组预定义的、互斥或可以组合的值。  
例如，您可以使用枚举来定义一年中的季节：

```C#
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
```

代码示例演示了如何定义枚举来表示互斥值。

枚举通过用有意义的名称替换数字字面量来提高代码可读性。  
它们还有助于防止分配无效值，因为只允许使用已定义的常量。*注*枚举还可以使用位标志来表示选择的组合，这对于文件权限或配置选项等场景非常有用。

## 定义枚举

要在 C# 中定义枚举，请使用`enum`关键字，后跟枚举的名称及其成员。

以下是一个简单的枚举类型示例，用于表示一周中的每一天：

```c#
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
```

代码示例演示了如何定义一个枚举类型来表示一周中的每一天。

枚举的底层类型默认为`int`，值从 0 开始，每个成员递增 1。

枚举类型仅限于整数类型（例如`int`、`byte`、`short`），不能表示字符串或小数等非整数值。

## 为枚举设置基础类型和值

您可以为枚举指定不同的基础整数类型，并为其成员分配自定义值。

例如：

```c#
enum ErrorCode : ushort
{
    None = 0,
    Unknown = 1,
    ConnectionLost = 100,
    OutlierReading = 200
}
```

代码示例演示了如何为枚举设置自定义基础类型和值。这种灵活性使枚举值能够与外部系统或特定要求保持一致。

*提示*避免使用`char`等非整数类型作为枚举的基础类型，这可能会导致不可靠的行为。

## 使用枚举执行转换

枚举支持其成员与基础整型之间的显式转换。 例如：

```c#
DaysOfWeek day = (DaysOfWeek)3;
Console.WriteLine(day); // Outputs: Wednesday
```

代码示例演示如何执行从整型值到枚举的显式转换。  
可以使用此方法验证枚举值`System.Enum.IsDefined`

```c#
bool isValid = Enum.IsDefined(typeof(DaysOfWeek), 3);
Console.WriteLine(isValid); // Outputs: True
```

代码示例演示如何使用`System.Enum.IsDefined`. 验证枚举值。
*提示*如果值无效，可以通过分配默认值或引发异常来确保安全使用来处理该值。

## 应用用于设计枚举的最佳做法

有效设计枚举：
- 对简单枚举使用单数名词，对标志枚举使用复数名词。
- 为简单枚举提供零值，通常命名`None`。
- 避免使用特殊值或保留值，因为它们可能会混淆用户。
- 使用两个用于标志枚举的权力来启用按位作。
*提示*请考虑将扩展方法添加到枚举，以获取更多功能，例如验证或格式设置。

## 使用自定义值和方法实现枚举

虽然枚举不能直接包含方法，但可以使用扩展方法添加功能。 例如：

```c#
public static class DaysOfWeekExtensions
{
    public static bool IsWeekend(this DaysOfWeek day)
    {
        return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
    }
}

DaysOfWeek today = DaysOfWeek.Saturday;
Console.WriteLine(today.IsWeekend()); // Outputs: True
```

代码示例演示如何使用扩展方法将功能添加到枚举中。
*提示*使用扩展方法在不修改枚举定义的情况下增强枚举，使其更具通用性和可重用性。

## 示例：使用枚举管理订单状态

枚举通常用于应用程序来表示预定义的值。 例如，在电子商务应用程序中，可以使用枚举来管理订单状态：

```c#
enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}

class Order
{
    public int OrderId { get; set; }
    public OrderStatus Status { get; set; }

    public void UpdateStatus(OrderStatus newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Order {OrderId} status updated to {Status}");
    }
}

var order = new Order { OrderId = 123, Status = OrderStatus.Pending };
order.UpdateStatus(OrderStatus.Shipped);
```

此示例演示如何为订单状态定义枚举，在类中使用它，并更新订单的状态。 它有助于初学者了解如何在实际方案中应用枚举。  

通过使用枚举，可以将数值文本替换为有意义的名称，使代码更加直观且更易于维护，同时启用显式转换和验证，以确保在项目中安全使用这些常量。

---

