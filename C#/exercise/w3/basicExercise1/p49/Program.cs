// Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.

int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

// 使用 Join() 方法分割数组，并使用 ', ' 分隔打印两个数组
Console.WriteLine("Array1: [{0}]", string.Join(", ", nums1));
Console.WriteLine("Array2: [{0}]", string.Join(", ", nums2)); ;

Console.WriteLine("Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.");

// 检查两个数组的长度是否大于等于 1
// 且两个元素的第一个元素相等
// 或两个元素的最后一个元素相等
Console.WriteLine(
 (nums1.Length >= 1 && nums2.Length >= 1)
 && (nums1[0].Equals(nums2[0])
 || nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])
 ));