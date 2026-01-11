/*
int first = 2;
string second =  "4";
int result = first + second;  // string 无法与 int 直接相加
Console.WriteLine(result);


int first = 2;
string second = "4";
string result = first + second;  // 正确转换
Console.WriteLine(result);
*/
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
//  int 可以轻松转换到decimal
*/
/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
//  decimal 转换到 int 会丢失小数点
*/
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
//  decimal 转换到 float是收缩转换，会丢失精度
*/
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
//  将两个 int 转换为 string 后拼接
*/
/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/
/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/
/*
int value = (int)1.5;  // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);  // converting rounds up
Console.WriteLine(value2);
*/

// 第三单元
/*
string name = "bob";
Console.WriteLine(int.Parse(name));
*/
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to reportthe measurement.");
}
*/
/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result >0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/