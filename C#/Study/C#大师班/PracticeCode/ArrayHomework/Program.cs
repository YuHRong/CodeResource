
string firstNames = "Jim, Bob, Salad";
string[] firstName = firstNames.Split(separator: ',');

Console.WriteLine("请输入你要选择的名字序号(1 到 3)");
try
{
 int input = int.Parse(Console.ReadLine());

 if (input >= 1 && input <= 3)
  Console.WriteLine(firstName[input - 1]);
 else
  Console.WriteLine("请输入1 到 3进行选择");
}
catch (FormatException)
{
 Console.WriteLine("输入错误，请输入数字。");
}
