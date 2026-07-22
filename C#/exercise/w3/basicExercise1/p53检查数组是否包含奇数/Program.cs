// Write a C# program to check if an array contains an odd number.

Console.WriteLine("\nCheck Odd Number in Array.");
Console.WriteLine("-------------------------------------------------\n");

int[] arr = { 2, 4, 7, 8, 6 };

Console.WriteLine($"Oringinal array: [{string.Join(", ", arr)}]");

Console.WriteLine($"Check if an array contains an odd number? {even_odd(arr)}");

bool even_odd(int[] nums)
{
 // 便利数组的每个元素
 foreach (var n in nums)
 {
  // 检查元素是奇数还是偶数
  if (n % 2 != 0)
   return true;
 }

 return false;
}