// Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range.
static int ConsecutiveArray(int[] inputArray)
{
 // 去重并排序
 //Array.Sort(inputArray);
 int[] sortArray = inputArray.Distinct().OrderBy(x => x).ToArray();
 int count = 0;   // 计数变量

 // 循环遍历排序后的数组，计算需要填充空白所需的数量
 for (int i = 0; i < sortArray.Length - 1; i++)
 {
  // 计数器等于相邻的元素相加的插值 - 1
  // 计算连续元素之间的缺失数量
  count += sortArray[i + 1] - sortArray[i] - 1;
 }

 // 返回计数变量
 return count;
}

Console.WriteLine(ConsecutiveArray(new int[] { 1, 3, 5, 6, 9 }));
Console.WriteLine(ConsecutiveArray(new int[] { 0, 10 }));
Console.WriteLine(ConsecutiveArray(new int[] { 1, 3, 3, 5, 7, 9 }));