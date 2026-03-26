# 使用 `List<T>` 实现有序集合

## 目录在这里

- [使用 `List<T>` 实现有序集合](#使用-listt-实现有序集合)
  - [目录在这里](#目录在这里)
  - [使用`List<T>`管理有序集合](#使用listt管理有序集合)
  - [添加、删除和遍历`List<T>`中的项目](#添加删除和遍历listt中的项目)
  - [通过`List<T>`管理学生或书籍列表](#通过listt管理学生或书籍列表)

C# 中的有序集合，如`List<T>`类，执行添加、删除和遍历项目等常见操作。

一个``List<T>`管理学生或书籍列表的示例。

## 使用`List<T>`管理有序集合

`List<T>`是一种通用集合，设计用于需要存储和管理特定类型（`T`）元素有序序列的场景。<br>与非通用集合（如`ArrayList`）相比，它提供类型安全、更好的性能和灵活性，访问元素时无需进行类型转换。

*注*`List<T>`中的`<T>`是列表存储元素的类型的占位符。例如，`List<string>`定义了一个字符串列表，而`List<int>`定义了一个整数列表。您在声明列表时要指定类型。

- 当您需要使用·List<T>·时：
  - 对元素进行索引访问。
  - 集合的动态调整大小。
  - 使用`foreach`循环进行高效的枚举。
- 避免在公共 API 中使用`List<T>`；相反，考虑使用更专业的集合类型以获得更好的抽象和灵活性。
*注*`List<T>`在需要时自动扩展其容量，但此扩展可能会影响性能。为优化性能，根据集合的估计大小设置初始容量。

## 添加、删除和遍历`List<T>`中的项目

`List<T>`提供了添加、删除和高效迭代项目的的方法。这些操作简单直接，在应用程序开发中常用。
- `添加项目`：要将元素添加到列表中，使用`Add`方法。
- `删除项目`：要删除元素，使用`Remove`、`RemoveAt`或`Clear`等方法。
- 遍历项目：为了枚举，使用`foreach`循环或语言集成查询（LINQ）。

```c#
// Example: Adding, removing, and iterating through a List<T>

// Define the type T as string for this list
List<string> books = new List<string>(); // T is string
books.Add("Book A"); // Add a string to the list
books.Add("Book B");
books.Add("Book C");
books.Remove("Book A"); // Remove a specific string from the list

foreach (string book in books) // Iterate through the list
{
    Console.WriteLine(book);
}

// Expected output:
// Book B
// Book C
```

这个示例演示了如何在添加项目到`List<T>`时保留现有元素，从列表的特定位置删除项目，以及遍历列表以显示其内容。*提示*LINQ 查询可以简化对`List<T>`的过滤、排序和分组操作。

## 通过`List<T>`管理学生或书籍列表

`List<T>`非常适合管理对象集合，例如学生或书籍。您可以为项目定义一个自定义类，并应用`List<T>`来存储和操作它们。

```c#
// Example: Managing a list of students
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

List<Student> students = new List<Student>
{
    new Student { Name = "Haneul", Age = 20 },
    new Student { Name = "Magda", Age = 22 }
};

students.Add(new Student { Name = "Dale", Age = 23 });
students.RemoveAt(0); // Remove Haneul

foreach (Student student in students)
{
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
}

// Expected output:
// Name: Magda, Age: 22
// Name: Dale, Age: 23
```

*注*在 UI 应用程序中进行动态数据绑定时，建议使用`ObservableCollection<T>`而不是`List<T>`，以便在集合变化时自动更新 UI。

在 C#中，`List`用于管理有序集合，提供类型安全、动态调整大小和高效枚举等功能，支持添加、删除和遍历项目等操作。

---
