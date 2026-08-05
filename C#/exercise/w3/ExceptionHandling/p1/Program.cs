// Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.

namespace ExceptionHandling;

public class Program
{
 static void Main(string[] args)
 {
  try
  {
   // 提示输入第一个数字
   Console.WriteLine("Input first number: "); ;
   string input1 = Console.ReadLine();    // 接受字符串输入
   double num1 = Convert.ToDouble(input1);    // 将输入转换为 double 类型

   // 提示输入第二个数字
   Console.WriteLine("Input second number: ");
   string input2 = Console.ReadLine();    // 接受字符串输入
   double num2 = Convert.ToDouble(input2);    // 将字符串转换为 double 类型

   // 检查 被除数是否为 0
   if (num2 != 0)
   {
    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
   }
   else
   {
    Console.WriteLine("Error: Cannot divide by zero.");
   }
  }
  catch (FormatException)
  {
   // 用于处理非数字输入错误的捕获
   Console.WriteLine("Error: Non-numeric value entered.");
  }
  catch (Exception ex)
  {
   // 用于处理其他类型异常的捕获
   Console.WriteLine("An error occurred: " + ex.Message);
  }
 }
}
