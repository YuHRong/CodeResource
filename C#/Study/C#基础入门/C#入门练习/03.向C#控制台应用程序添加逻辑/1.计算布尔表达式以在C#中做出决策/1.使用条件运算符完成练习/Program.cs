// 在此练习中，将实现条件运算符来模拟“掷硬币”。生成的决策逻辑将显示 heads 或 tails。

Random random = new Random();
int poin = random.Next(0, 2);
Console.WriteLine((poin == 0) ? "heads" : "tails");