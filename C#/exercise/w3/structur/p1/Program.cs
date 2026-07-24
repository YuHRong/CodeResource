// Write a program in C# Sharp to declare a simple structure.

struct sumStruct
{
 public int x;
 public int y;
}

class textMessage
{
 static void Main()
 {

  Console.Write("\n\nDeclare a simple structure :\n");
  Console.Write("--------------------------------\n");

  // 创建 sumStruct 结构的实力
  sumStruct sumSt = new sumStruct();

  // 给结构实例中的x和y变量赋值
  sumSt.x = 13;
  sumSt.y = 27;

  // 计算结构中 x 和 y 的和
  int sum = sumSt.x + sumSt.y;

  // 打印结果
  Console.WriteLine($"The sum of x and y is {sum}\n");
 }
}
