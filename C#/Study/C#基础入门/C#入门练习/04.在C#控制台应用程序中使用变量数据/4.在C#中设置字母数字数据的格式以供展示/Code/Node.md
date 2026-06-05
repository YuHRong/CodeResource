# 字符串

## 字符串格式

- `:N` 在数字后面指定小数点指定小数点
- `:P` 打印百分比
- `:C` 打印货币格式

## PadLeft() 方法

将空格添加到字符串的左侧，使字符总数等于发送该字符串的参数。 在这种情况下，需要字符串的总长度为 12 个字符。

### 代码示例： 

```
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 ```

 ## PadRight() 方法

 将空格符添加到字符串右侧。

 还可以在字符串两边添加其他空白符，

### 代码示例：

```c#
Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));
```

## 字符串比较方法

Trim()`、` TrimStart()`、` TrimEnd()`、` GetHashcode()`、` Length `属性`

## 帮助确定字符串内部内容的方法，甚至只检索字符串的一部分（

`Contains()`、 `StartsWith()`、`EndsWith()`、 `Substring()`

## 替换删除字符串方法

`Replace()`、 `Insert()`、 `Remove()`

## 将字符串转换为字符串或字符数组的方法 （

`Split()`，`ToCharArray()`

