//client.cs 客户程序
using MyShape;
using System;
 using MyMessage;

 class ClientTest
{
 public static void Main()
 {
  int score = 1000;  //总分
  int win;  //每一局迎娶的分数
  int choice;  //随机获得的图形号
  int bet;  //每一局的下注
  string s;
  Shape sp = new Shape();
  Random random = new Random();
  Message msg = new Message();
  msg.Begin();

  while (true)
  {
   if (!msg.Ask())
    break;
   Console.WriteLine("Your Score: {0}", score);
   Console.WriteLine("Enter your bet: ");
   Console.ReadLine();

   s = Console.ReadLine();
   //如果 押注的输入不正确 进行异常处理 并默认下注为 100 分
   try
   {
    bet = s.ToInt32();
   }
   catch
   {
    bet = 100;
   }

   if (bet < score)
    score -= bet;
   else
   {
    bet = score;
    score = 0;
   }
   Console.WriteLine("Remain Score: {0}", score);

   win = 0;
   for (int i = 0; i < 3; i++)
   {
    choice = random.Next() % 4;  //随机数发生器
    switch (choice)
    {
     case 0:
      sp = new RectTriangle(5, 4);
      goto end;
     case 1:
      sp = new RectEqualTriangle(5);
      goto end;
     case 2:
      sp = new Rectangle(5, 4);
      goto end;
     case 3:
      sp = new Square(5);
    }
   end: //利用多态性 计算得分
    sp.Draw();
    win += sp.GetArea() * (i + 1) * bet / 100;
    Console.WriteLine("Your win: {0}", win);
   }
   score += win;
   Console.WriteLine("Your Score: {0}", score);

   if (score < 100)
   {
    Console.WriteLine("Your remain score is not enough to play");
    break;
   }
  }
 }
}