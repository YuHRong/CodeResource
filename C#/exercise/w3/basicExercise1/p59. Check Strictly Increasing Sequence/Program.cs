// Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.

bool TestIncreasingSequence(int[] int_seq)
{
 int count = 0;    //计数器用于跟踪所需更改的数量

 // 遍历数组以检查非递增元素并计算所需的更改
 for(int i = 0; i < int_seq.Length - 1; i++)
 {
  // 检查当前元素是否大于或等于下一个元素
  if (int_seq[i] >= int_seq[i + 1])
   count++;   // 需要更改时增加计数器

  // 通过比较当前和下一个元素检查是否可能更大
  if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
   count++;    // 需要更改时增加计数器
 }

 // 如果所需更改的数量最多为2（即数组最多可以增加一次更改），则返回true
 return count <= 2;
}

// 测试数据
Console.WriteLine(TestIncreasingSequence(new int[] { 1, 3, 5, 6, 9 }));  // Output: True
Console.WriteLine(TestIncreasingSequence(new int[] { 0, 10 }));         // Output: True
Console.WriteLine(TestIncreasingSequence(new int[] { 1, 3, 1, 3 }));    // Output: False
