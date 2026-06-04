/*
在迭代语句的代码块内输出从 1 到 100 的值，每行一个数字。
如果当前值可被 3 整除，则在该数字旁打印  Fizz 。
如果当前值可被 5 整除，则在该数字旁打印  Buzz 。
如果当前值可 同时 被 3 和 5 整除，则在该数字旁打印术语  FizzBuzz 。
*/

for (int i = 1; i <= 100; i++)
{
 if (i % 3 == 0 && i % 5 == 0)
  Console.WriteLine($"{i} - FizzBuzz");
 else if (i % 3 == 0)
  Console.WriteLine($"{i} - Fizz");
 else if (i % 5 == 0)
  Console.WriteLine($"{i} - Buzz");
 else
  Console.WriteLine(i);
}