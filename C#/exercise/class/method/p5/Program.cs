

class Program
{
 // 默认参数 power 等于 2
 static double Power(double baseNum, int power = 2)
 {
  double result = 1;

  for (int i = 0; i < power; i++)
   result *= baseNum;

  return result;
 }

 // 多个默认参数
 static void PrintInfo(string name, int age = 18, string city = "未知")
 {
  Console.WriteLine($"{name}, {age}岁, {city}");
 }

 static void Main()
 {
  // 使用默认参数
  Console.WriteLine(Power(3.0));
  Console.WriteLine(Power(3, 3));

  // 命名参数：跳过 age，只指定 city
  PrintInfo("小明", city: "北京");    // 输出：小明, 18岁, 北京

  // 命名参数不按顺序
  PrintInfo(city: "上海", name: "小红", age: 25);
 }
}