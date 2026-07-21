
using p3;

double num1, num2;
Calculator calculator = new Calculator();

Console.WriteLine("请输入第一个数字： ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入第二个数字： ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("请输入运算符");
char op = Convert.ToChar(Console.ReadLine());

MenuChoice(op);

void MenuChoice(char op)
{
  double result;

  switch (op)
  {
    case '+':
      result = calculator.CalculateAdd(num1, num2);
      Console.WriteLine($"{num1} {op} {num2} = {result}");
      break;
    case '-':
      result = calculator.CalculateSub(num1, num2);
      Console.WriteLine($"{num1} {op} {num2} = {result}");
      break;
    case '*':
      result = calculator.CalculateMob(num1, num2);
      Console.WriteLine($"{num1} {op} {num2} = {result}");

      break;
    case '/':
      if (num2 == 0)
      {
        Console.WriteLine("被除数不能为 0");
      }
      else
      {
        result = calculator.CalculateDis(num1, num2);
        Console.WriteLine($"{num1} {op} {num2} = {result:F2}");
      }
      break;

    default:
      Console.WriteLine("输入错误，请重新输入");
      break;
  }
}
