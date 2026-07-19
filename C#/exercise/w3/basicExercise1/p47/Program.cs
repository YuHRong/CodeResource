
// 申明数组并赋值
int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
int sum = 0;    // 申明存储数组元素总和的变量

Console.WriteLine("\nArray1: [{0}]\n", string.Join(", ", array1));

// 使用 for 循环便利数组中的每一个值
for (int i = 0; i < array1.Length; i++)
{
 // 计算数组中元素的和并存储在 sum 中
 sum += array1[i];
}

Console.WriteLine($"Sum: {sum}");
