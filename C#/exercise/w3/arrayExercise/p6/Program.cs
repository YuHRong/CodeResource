// Write a program in C# Sharp to print all unique elements in an array.

int n;    // 用于获取输入元素数量的变量
int[] arr1 = new int[100];


Console.Write("\n\nPrint all unique elements of an array:\n");
Console.Write("------------------------------------------\n");
Console.Write("Input the number of elements to be stored in the array :");

n = Convert.ToInt32(Console.ReadLine());

// 使用循环便利存储输入的元素值
Console.WriteLine($"Input {n} elements in the array :");
for (int i = 0; i < n; i++)
{
 Console.Write($"Element - {i} : ");
 arr1[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("The unique elements found in the array are :");

// 检查唯一的元素
for (int i = 0; i < n; i++)
{
 int count = 0;    // 将计数变量初始化为0，循环开始自动赋值 0

 for (int j = 0; j < n; j++)
 {
  if (arr1[i] == arr1[j])
  {// 检查arr1[i] 是否等于 arr1[j]
   // 如果 arr1[i] 等于 arr1[j]则计数器递增
   count++;
  }
 }

 // 判断 count 是否等于 1
 if (count == 1)
 {    // 如果 count = 1，打印 arr1[i] 的唯一值
  Console.WriteLine($"{arr1[i]}");
 }
}

Console.WriteLine();
Console.ReadLine();