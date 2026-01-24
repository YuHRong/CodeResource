Random dice = new Random();
Console.WriteLine("请输入1到100的数字");

int userGuess;
while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess  < 1 || userGuess > 100)
{
     Console.WriteLine("输入无效，请重新输入1到100的数字：");
}

int roll = dice.Next(1, 101);

Console.WriteLine($"正确答案是: {roll}");
Console.WriteLine($"你猜的是: {userGuess}");

if (userGuess == roll)
{
     Console.WriteLine("🎉 恭喜你猜对了！");
}
else
{
      Console.WriteLine($"猜错了，相差 {Math.Abs(userGuess - roll)}，下次加油！");
}