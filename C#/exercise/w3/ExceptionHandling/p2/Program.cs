//Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. Handle the exception in the calling code.

try
{
 Console.WriteLine("Input an integer: ");
 string input = Console.ReadLine();
 int n = Convert.ToInt32(input);

 IntegerNum(n);

 //如果输入通过验证，则显示为有效
 Console.WriteLine("Valid input: " + n);
}
catch (NegativeNumberException ex)
{
 // 用于处理NegativeNumberException的捕获块
 Console.WriteLine("Error!" + ex.Message);
}
catch (FormatException)
{
 //用于处理FormatException（非整数输入）的捕获
 Console.WriteLine("Error: Invalid input. Please enter an integer.");
}
catch (Exception ex)
{
 // Catch block for handling other types of exceptions
 Console.WriteLine("An error occurred: " + ex.Message);
}

int IntegerNum(int n)
{
 if (n < 0)
  // 如果数字为负数，则抛出NegativeNumberException
  throw new NegativeNumberException("Negative number not allowed.");

 // 如果输入的数字大于等于 0，正常返回
 return n;
}

//用于处理负数情况的自定义异常类
class NegativeNumberException : Exception
{
 public NegativeNumberException(string message) : base(message) { }
}