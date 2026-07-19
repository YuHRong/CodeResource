//Write a C# program to create a string of every other character (odd position) from the first position of a given string.

Console.WriteLine("Input a string : "); ;
string str = Console.ReadLine();

//创建一个空字符串，将字符串存储在偶数索引处
var result = string.Empty;

//使用for 循环便利输入的字符
for (var i = 0; i < str.Length; i++)
{
 // 检查索引“i”是否为偶数（即，可被2整除，无余数）
 // 如果索引为偶数，则将索引“i”处的字符添加到“result”字符串中
 if (i % 2 == 0)
 {
  result += str[i];
 }
}
 //输出 result 
 Console.WriteLine(result);
