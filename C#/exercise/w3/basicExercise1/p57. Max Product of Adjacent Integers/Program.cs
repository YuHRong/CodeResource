// Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.

// 输入测试

Console.WriteLine(AdjacentElementsProduct(new int[] { 1, 3, -5, -4, 8, -5 }));
Console.WriteLine(AdjacentElementsProduct(new int[] { 1, 3, -4, 5, 2 }));
Console.WriteLine(AdjacentElementsProduct(new int[] { 1, 3, 4, 5, 2 }));

static int AdjacentElementsProduct(int[] inputArray)
{
 // 用数组中前两个元素的乘积初始化最大乘积
 int max = inputArray[0] * inputArray[1];


 // 遍历数组以找到相邻元素的最大乘积
 for (int i = 1; i < inputArray.Length - 2; i++)
 {
  // 用当前最大值和当前元素与下一个元素的乘积的最大值更新max变量
  max = Math.Max(max, inputArray[i] * inputArray[i + 1]);
 }

 // 返回相邻元素的最大乘积
 return max;
}