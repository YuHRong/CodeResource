# 程序分析

## 源程序
 原程序见[这里](Program.cs)

### 变量
```c#
// Write a C# Sharp program to insert an additional value into an array (sorted list).

const int len = 100;
int[] arr = new int[len];
int n, value, i, j;
```
- 申明一个长度为`100`的`len`常量，用于存储数组的容量。
- 申明一个`int`类型数组，长度为`len`。
- 申明变得`n`用于存储当前数组长度。
  - 申明获取插入数组的值。
  - 申明迭代器变量，后在循环内赋值。

### 提示信息
Console.Write("\n\nInsert an additional value into an array (sorted list) :\n");
Console.Write("---------------------------------------------------------\n");

Console.Write("Input the size of array : ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array in ascending order :");
for (i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Input the value to be inserted : ");
value = Convert.ToInt32(Console.ReadLine());

// 打印原数组
Console.WriteLine("The original array is :");
for (i = 0; i < n; i++)
{
 Console.Write($"{arr[i]} ");
}
Console.WriteLine();
```
- 打印题目信息，并提示输入数组长度。
- 获取数组长度。
- 循环输入数组元素。
- 获取需要插入的值，并存储在`value`中。
- 打印原数组。

### 插入值循环
```c#
// 确定插入新值的位置
for (i = 0; i < n; i++)
{
 if (value < arr[i])
 {
  // 将元素向后移动一位
  for (j = n; j > i; j--)
  {
   arr[j] = arr[j - 1];
  }
  // 插入新元素
  arr[i] = value;
  break;
 }
}

// 如果新值大于所有元素，则将其插入到数组末尾
if (i == n)
{
 arr[n] = value;
}

// 打印插入新值后的数组
Console.WriteLine("The new array is :");
for (i = 0; i <= n; i++)
{
 Console.Write($"{arr[i]} ");
}
Console.WriteLine();
```
- 使用循环便利数组。
- 如果`value`小于`arr[i]`，找到插入点，则插入点为 `i`。
  - 使用循环将元素向后移动一位
    - 循环条件为`j = n; j > i; j--`
    - 当`n > i`时，将`arr[j - 1]`向后移动。
  - 在此处将`value`赋值给`arr[i]`，并break循环。
- 当新值大于所有元素，将其放在数组后。
- 打印新数组。
