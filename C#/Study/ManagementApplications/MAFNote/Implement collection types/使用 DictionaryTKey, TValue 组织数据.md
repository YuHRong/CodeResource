# 使用 `Dictionary<TKey, TValue>` 组织数据

## 目录在这里

- [使用 `Dictionary<TKey, TValue>` 组织数据](#使用-dictionarytkey-tvalue-组织数据)
  - [目录在这里](#目录在这里)
  - [定义并解释 `Dictionary<TKey, TValue>` 的用途，用于组织键值对](#定义并解释-dictionarytkey-tvalue-的用途用于组织键值对)
  - [在 `Dictionary<TKey, TValue>` 中添加、检索和遍历键值对](#在-dictionarytkey-tvalue-中添加检索和遍历键值对)
    - [添加键值对](#添加键值对)
    - [获取值](#获取值)
    - [遍历键值对](#遍历键值对)
  - [使用 `Dictionary<TKey, TValue>`创建像电话簿或产品 ID 到价格映射这样的实用应用程序](#使用-dictionarytkey-tvalue创建像电话簿或产品-id-到价格映射这样的实用应用程序)
    - [电话簿](#电话簿)
    - [产品 ID 到价格的映射](#产品-id-到价格的映射)

`Dictionary 是 C# 中的一种泛型集合，它将数据存储为键值对，其中每个键都是唯一的，并映射到一个特定的值。`它适用于需要基于唯一标识符进行快速查找的场景，例如创建电话簿或将产品 ID 映射到价格。

## 定义并解释 `Dictionary<TKey, TValue>` 的用途，用于组织键值对

`Dictionary<TKey, TValue>`是 C# 中`System.Collections.Generic`命名空间的一部分。它以键值对的形式存储数据，其中每个键都是唯一的，并映射到特定的值。这种结构非常适合需要根据唯一标识符进行快速查找的场景。
- 字典中的键必须是唯一的。
- 值可以是任何类型，包括自定义对象。

`Dictionary<TKey, TValue>`类提供了`Add`等方法用于插入新键值对，并提供了索引器用于通过键访问值。
*注*如果你尝试使用`Add`方法添加重复的键，会抛出`ArgumentException`异常。但是，使用索引器会覆盖与该键关联的现有值。

## 在 `Dictionary<TKey, TValue>` 中添加、检索和遍历键值对

向字典添加键值对可以使用`Add`方法或索引初始化器。使用键可以方便地检索值，并且可以使用循环进行遍历。

### 添加键值对

你可以使用集合初始化器或`Add`方法来初始化字典：

```c#
var students = new Dictionary<int, string>
{
    { 101, "Ji-min Jo" },
    { 102, "Catalina Blaga" }
};

students.Add(103, "Milan Golob"); // Add a new key-value pair

foreach (var kvp in students)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Expected output:
// Key: 101, Value: Ji-min Jo
// Key: 102, Value: Catalina Blaga
// Key: 103, Value: Milan Golob
```

这段示例初始化了一个包含学生 ID 和姓名的字典，添加了一个新学生，并遍历字典以显示所有键值对。

### 获取值

使用键访问值：

```c#
var students = new Dictionary<int, string>
{
    { 101, "Ji-min Jo" },
    { 102, "Catalina Blaga" }
};

var student = students[101];
Console.WriteLine(student); // Outputs "Ji-min Jo"

// Expected output:
// Ji-min Jo
```

这段代码获取与键 `101` 关联的值，并显示学生的姓名。

### 遍历键值对

使用`foreach`循环遍历字典：

```c#
var students = new Dictionary<int, string>
{
    { 101, "Ji-min Jo" },
    { 102, "Catalina Blaga" },
    { 103, "Milan Golob" }
};

foreach (var kvp in students)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Expected output:
// Key: 101, Value: Ji-min Jo
// Key: 102, Value: Catalina Blaga
// Key: 103, Value: Milan Golob
```

这段代码遍历字典中的所有键值对，并显示每个键及其对应值。

## 使用 `Dictionary<TKey, TValue>`创建像电话簿或产品 ID 到价格映射这样的实用应用程序

`Dictionary<TKey, TValue>`的多功能性使其适用于现实世界的应用程序，例如：

### 电话簿

存储联系人姓名和电话号码：

```c#
var phonebook = new Dictionary<string, string>
{
    { "Ji-min Jo", "312-555-0100" },
    { "Catalina Blaga", "251-555-0101" }
};

Console.WriteLine(phonebook["Ji-min Jo"]); // Access Ji-min's phone number

// Expected output:
// 312-555-0100
```

这段示例演示了如何使用字典来按名称存储和检索电话号码。

### 产品 ID 到价格的映射

将产品 ID 映射到其价格：

```c#
var productPrices = new Dictionary<int, decimal>
{
    { 201, 19.99m },
    { 202, 29.99m }
};

Console.WriteLine($"Product 201 costs ${productPrices[201]}");

// Expected output:
// Product 201 costs $19.99
```

这段代码演示了如何使用字典将产品 ID 映射到它们的价格，并检索特定产品的价格。

这些示例展示了`Dictionary<TKey, TValue>`如何简化您应用程序中的数据管理任务。

---
