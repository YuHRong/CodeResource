// Write a C# program to multiply the corresponding elements of two integer arrays.

int[] array1 = { 1, 3, -5, 4 };
int[] array2 = { 1, 4, -5, -2 };

// 显示数组1和数组2的元素
Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
Console.WriteLine($"\nArray2: [{string.Join(", ", array2)}]");

// 显示两个数组元素相乘的消息
Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

// 循环遍历数组以乘以相应的元素并显示结果
for (int i = 0; i < array1.Length; i++)
{
 Console.Write(array1[i] * array2[i]+ " ");
}

 Console.WriteLine("\n");