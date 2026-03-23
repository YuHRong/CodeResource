# C# 中的 null 

<div>
## 了解 null 性

如果你是 .NET 开发人员，你可能会遇到`System.NullReferenceException`。 当取消引用`null`时（即在运行时评估变量，但变量引用`null`时），则会在运行时出现这种情况。 迄今为止，此异常是 .NET 生态系统中最常见的异常。`null`的创建者（Tony Hoare 爵士）将`null`称为“十亿美元的错误”。

示例将 `FooBar`分配给 `null`并立即取消引用，从而出现问题：:

    // Declare variable and assign it as null.
    FooBar fooBar = null;

    // Dereference variable by calling ToString.
    // This will throw a NullReferenceException.
    _ = fooBar.ToString();

    // The FooBar type definition.
    record FooBar(int Id, string Name);

## null 的类型

在 C# 2.0 之前，只有引用类型可为空。 `int` 或 `DateTime` 之类的值类型不能为 `null`。 如果这些类型在没有值的情况下被初始化，它们会回退到其 `default` 值。 对于 `int` ，此值为 `0`。 对于 `DateTime`，此值为 `DateTime.MinValue`。

不带初始值的实例化引用类型的工作方式不同。 所有引用类型的`default`值均为`null`。

示例： 

    string first;                  // first is null
    string second = string.Empty   // second is not null, instead it's an empty string ""
    int third;                     // third is 0 because int is a value type
    DateTime date;                 // date is DateTime.MinValue

上例中
- `first` 是 `null`，因为声明了引用类型`string`，但未进行赋值。
- `second`在声明时被赋予`string.Empty`。 对象从不具有`null`赋值。
- `third`是`0`，尽管未被赋予。 它是一个`struct`（值类型），并且`default`值为`0`。
- `date`未初始化，但其``default`值为`System.DateTime.MinValue`。

从 C# 2.0 开始，可以使用`Nullable<T>`）定义可空值类型。 这允许值类型可为空。 请看示例：

`int`? first`;            `// first is implicitly null (uninitialized)`
`int`? second =` `null`;`    // second is explicitly null
`int`? third = `default`;  `// third is null as the default value for Nullable<Int32> is null`
`int`? fourth = `new()`;    `// fourth is 0, since new calls the nullable constructor`

C# 8.0 引入了可为空的引用类型，你可以在其中表达你的意图，即引用类型可能是`或始终为非`

#nullable enable

string `first` = string.Empty`;`
string `second`;
string`? third`;

鉴于上面的示例，编译器会推断你的意图，如下：
- `first`永远不为`null`，因为它是明确赋值的。
- `second`应永远不为`null`，即使它最初为`null`。`null` 在赋值之前评估 `second` 会导致编译器警告，因为它未初始化。
- `third`可能是`null`。例如，它应指向`System.String`，但它可能指向`null`。 其中的任何一种变化都是可接受的。 如果取消引用`third

