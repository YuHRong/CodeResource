# 使用 `HashSet<T>`确保唯一性

## 目录在这里

- [使用 `HashSet<T>`确保唯一性](#使用-hashsett确保唯一性)
  - [目录在这里](#目录在这里)
  - [使用 C#中的 `HashSet<T>`管理唯一集合](#使用-c中的-hashsett管理唯一集合)
  - [在 `HashSet<T>` 集合中添加、验证和防止重复项。](#在-hashsett-集合中添加验证和防止重复项)
    - [添加项目](#添加项目)
    - [验证项目](#验证项目)
    - [防止重复](#防止重复)
  - [使用 `HashSet<T>`示例高效管理唯一电子邮件地址](#使用-hashsett示例高效管理唯一电子邮件地址)
    - [示例：](#示例)

`HashSet<T>`类为开发者提供了一种高效处理唯一元素集合的方式，确保不存在重复项。<br>例如，在维护唯一电子邮件地址列表时，非常有用，因为它可以确保在添加项时进行验证且不重复。

## 使用 C#中的 `HashSet<T>`管理唯一集合

`HashSet<T>`类专为高性能集合操作而设计。它确保集合中的所有元素都是唯一的且无序的。与其他允许重复元素的集合（如`List<T>`）不同，
- `HashSet<T>`会自动防止重复条目。
- `HashSet<T>`的容量会随着元素的添加而动态增加。
- `HashSet<T>`基于数学集合运算，如并集、交集和差集。
- 如果您的应用程序优先考虑性能而不是元素顺序或重复，`HashSet<T>`是理想的选择。

对于需要排序集合或重复元素的应用程序，请考虑使用`List<T>`并结合排序方法。
*注意*`HashSet<T>`类实现了`ISet<T>`接口，提供了更多的集合操作，如子集和超集比较。

## 在 `HashSet<T>` 集合中添加、验证和防止重复项。

向`HashSet<T>`添加项目很简单，并确保不会引入重复项。当你尝试添加一个已存在的项目时，操作会静默失败而不会抛出错误。

### 添加项目

使用`Add`方法将元素插入到集合中。例如：

```c#
HashSet<string> names = new HashSet<string>();
names.Add("Haneul");
names.Add("Magda");

foreach (string name in names) {
    Console.WriteLine(name);
}

// Output (order may vary):
// Haneul
// Magda
```

这段示例向 `HashSet<T>` 添加唯一名称，并遍历集合来显示。

### 验证项目

要检查项目是否存在于集合中，请使用`Contains`方法：

```c#
HashSet<string> names = new HashSet<string>();
names.Add("Haneul");
names.Add("Magda");

if (names.Contains("Haneul")) {
    Console.WriteLine("Haneul is in the collection.");
}

// Output:
// Haneul is in the collection.
```

这段示例检查特定的名称是否存在于 `HashSet<T>` 中，如果存在，则显示一条消息。

### 防止重复

由于`HashSet<T>`本质上防止了重复，因此你不需要额外的逻辑来处理它们。

尝试再次添加 "Mia" 不会修改集合。

```c#
HashSet<string> names = new HashSet<string>();
names.Add("Haneul");
names.Add("Magda");
names.Add("Mia");
names.Add("Mia"); // Duplicate, won't be added

foreach (string name in names) {
    Console.WriteLine(name);
}

// Output (order may vary):
// Haneul
// Magda
// Mia
```

这段示例演示了向 `HashSet<T>` 添加重复元素不会产生效果，确保所有元素保持唯一。

*提示*使用 `HashSet<T>` 处理必须保持唯一的数据，例如 ID 或用户名。

## 使用 `HashSet<T>`示例高效管理唯一电子邮件地址

`HashSet<T>`的一个常见用例是管理唯一电子邮件地址，确保不存储重复的电子邮件，简化发送通知或验证用户账户等操作。

### 示例： 

```c#
HashSet<string> emailAddresses = new HashSet<string>();
emailAddresses.Add("user1@example.com");
emailAddresses.Add("user2@example.com");
emailAddresses.Add("user1@example.com"); // Duplicate, won't be added

foreach (string email in emailAddresses) {
    Console.WriteLine(email);
}

// Output:
// user1@example.com
// user2@example.com
```

此示例将电子邮件地址添加到 `HashSet<T>` 中，并确保不存储重复项。
*注*使用 `HashSet<T>` 进行电子邮件管理，与在  List<T>  中手动检查重复项相比，性能更优。

---
