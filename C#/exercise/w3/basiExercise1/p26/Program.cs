int num = 500;

// Console.WriteLine("Enter a integer: ");
// num = Convert.ToInt32(Console.ReadLine());

// 初始化变量保存素数的和
// 初始化变量技术保存素数
int sum = 0, count = 0;

// 从第一个素数开始
int n = 2;

// 循环查找 500 以内的素数并求和
while (count < num)
{
 // 调用方法检查是否是素数
 if (isPrime(n))
 {
  // 将素数加到 sum
  sum += n;

  // 递增计数
  count++;
 }
 n++;    // 移动到下一个数字
}

Console.WriteLine($"Sum of the first {num} prime numbers: ");
Console.WriteLine(sum);




static bool isPrime(int n)
{
 // 计算“n”的平方根
 int x = (int)Math.Floor(Math.Sqrt(n));

 // 1 不是素数
 if (n == 1) return false;

 // 2 是素数
 if (n == 2) return true;

 // 循环检查'n'是否能被从2到'n'平方根的任何数字整除
 for (int i = 2; i <= x; i++)
 {
  // 如果'n'能被'i'整除，它就不是素数
  if (n % i == 0) return false;
 }

 // 如果n不能被除1和它自身之外的任何数字整除，则它是素数
 return true;
}