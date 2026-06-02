Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

// 如果用户的订阅已过期
 if (daysUntilExpiration == 0)
{
 Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
 Console.WriteLine("Your subscription expires within a day!");
 discountPercentage = 20;
}
// 如果用户的订阅将在 5 天或更短的时间内到期
else if (daysUntilExpiration <= 5)
{
 Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
 discountPercentage = 10;
}
// 如果用户的订阅将在 10 天或更短的时间内到期
else if (daysUntilExpiration <= 10)
{
 Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// 创建一个单独的  if  语句来显示折扣套餐。
if (discountPercentage > 0)
{
 Console.WriteLine($"Renew now and save {discountPercentage}%!");
}