// Write a program in C# Sharp to declare a simple structure and use static fields inside a struct.

struct w3rStruct
{
 public static int x = 15;    // 初始化 x 的值为15
 public static int y = 28;    // 初始化 y 的值为 28
}


class Program
{
 static void Main()
 {
  Console.Write("\n\nStructure with the use of static fields inside a structure :\n");
  Console.Write("-------------------------------------------------------------\n");

  //计算结构w3rStruct中静态变量x和y的总和
  int sum = w3rStruct.x + w3rStruct.y;


  Console.WriteLine($"The sum of x and y is {sum}\n");
 }
}