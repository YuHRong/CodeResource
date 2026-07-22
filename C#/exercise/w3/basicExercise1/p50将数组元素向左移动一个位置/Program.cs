// Write a C# program to rotate an array (length 3) of integers in the left direction.

int[] arr1 = { 1, 2, 8 };

Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));

// 申明灵石变量 temp
// 将 arr1 中的第一个元素存储在 temp 中
int temp = arr1[0];

// 使用for循环遍历'nums'数组的元素（最后一个元素除外）
for (int i = 0; i < arr1.Length - 1; i++)
{
 // 将每个元素向左移动一个位置
 arr1[i] = arr1[i + 1];
}

// 将temp 中的值付给 arr1 的最后一个元素
arr1[arr1.Length - 1] = temp;

// 打印旋转后的 arr1 数组的值
Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(" ", arr1));