// Write a C# Sharp program to get the day of the week for a specified date.

// 创建 DateTime 类对象
// 写入需要获取的日期
DateTime dayWeek = new DateTime(2016, 7, 11);

// 格式化打印日期并打印周几
Console.WriteLine($"The day of the week for {dayWeek.ToString("M/d/yyyy")} is {dayWeek.DayOfWeek}");
