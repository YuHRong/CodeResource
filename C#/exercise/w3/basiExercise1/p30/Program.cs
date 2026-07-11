// Hexadecimal to Decimal
// Write a C# program to convert a hexadecimal number to a decimal number.

// 申明字符串变量获取十六进制输入
string hexval = "";

// 提示输入十六进制数
Console.WriteLine("Enter a Hexadecimal number: ");
hexval = Console.ReadLine();

// 显示输入的十六进制数
Console.WriteLine("Hexadecimal number: " + hexval);

// 将输入的十六进制 hexadecimal 转换为十进制数
int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

//显示一条消息，指示转换为不同的数字系统
Console.WriteLine("Convert to-");

//显示十六进制转换得到的十进制值
Console.WriteLine("Decimal number: " + decValue);