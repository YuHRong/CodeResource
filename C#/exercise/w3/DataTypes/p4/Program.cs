// Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.

double n1, n2, sum;
char op;

try
{
 Console.Write("Input first number: ");
 n1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Input operation: ");
 op = Convert.ToChar(Console.ReadLine());

 Console.Write("Input second number: ");
 n2 = Convert.ToDouble(Console.ReadLine());

 sum = Calculator(n1, op, n2);

 Console.WriteLine($"{n1} {op} {n2} = {sum}");
}
catch (Exception ex)
{
 Console.WriteLine($"输入错误 {ex.Message}");
}

double Calculator(double n1, char ch, double n2)
{
 double sum = 0;
 switch (ch)
 {
  case '+': sum = n1 + n2; break;
  case '-': sum = n1 - n2; break;
  case '*': sum = n1 * n2; break;
  case '/':
   if (n2 == 0)
   {
    Console.WriteLine("被除数不能为 0");
   }
   break;
  default:
   Console.WriteLine("运算符错误！");
   break;
 }

 return sum;
}