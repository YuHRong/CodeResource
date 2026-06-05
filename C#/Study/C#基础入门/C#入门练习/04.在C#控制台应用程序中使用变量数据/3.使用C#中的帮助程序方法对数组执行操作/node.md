# Array 类

Array 类具有可以操纵数组大小和内容的方法。

## Sort()

按字母排序

## Reverse()

反向排列

### 代码示例

```c#
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
 Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
 Console.WriteLine($"-- {pallet}");
}
```

## Clear()

使用 `Array.Clear()` 方法可以清除数组中特定元素的内容，从而将其替换为数组的默认值。 
例如，如果清除 `string` 数组中的元素，则清除的值将替换为 `null`。 同样，在清除 `int`  数组中的元素时，将替换为 `0`。
另外，使用  Array.Resize()  方法可以从数组中添加或移除元素。

### 示例代码： 

```c#
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

### 添加元素代码示例： 

```c#
string[] pallets =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

### 移除元素代码示例： 

```c#
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
```

# String 类

## ToCharArray()

反向排列 `string`

### 代码示例： 

```c#
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
```

## Join()

将所有字符合并为新的逗号分隔值字符串

### 代码示例： 

```c#
string result = String.Join(",", valueArray);
```

## Split()

拆分为字符串 

### 代码示例： 

```c#
string[] items = result.Split(',');

// 使用 foreach 循环便利访问字符串
foreach (string item in items)
{
}
    Console.WriteLine(item);
}
```