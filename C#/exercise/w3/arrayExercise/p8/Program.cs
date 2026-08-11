//Write a C# Sharp program to count the frequency of each element in an array.

class Program
{
 static void Main()
 {
  const int arrSize = 100;
  int n, count = 0;
  int[] arr1 = new int[arrSize];
  int[] arr2 = new int[arrSize];

  Console.WriteLine("Input the number of elements to be stored in the array :");
  n = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Input {0} elements in the array :", n);
  for (int i = 0; i < n; i++)
  {
   Console.Write("element - {0} : ", i);
   arr1[i] = Convert.ToInt32(Console.ReadLine());
   arr2[i] = -1;    // 使用 -1 初始化频率数组
  }

  for (int i = 0; i < n; i++)
  {
   count = 1;    // 将计数器初始化为 1
   for (int j = i + 1; j < n; j++)
   {    // 如果 arr1[i] 等于 arr[j]  count ++
    if (arr1[i] == arr1[j])
    {
     count++;
     arr2[j] = 0;    //通过将重复项的频率设置为0来标记重复项
    }
   }

   if (arr2[i] != 0)
   {    // 如果不是重复
        // 存储出现的次数
    arr2[i] = count;
   }
  }

  Console.WriteLine("\nThe frequency of all elements of the array : \n");
  for (int i = 0; i < n; i++)
  {
   if (arr2[i] != 0)
   {    // 如果频率不为0（表示重复）
    Console.WriteLine("{0} occurs {1} times", arr1[i], arr2[i]);
   }
  }

 }
}