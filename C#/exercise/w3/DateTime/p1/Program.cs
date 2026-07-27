// Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output.

// 创建具有特定时间值的 DateTime 对象
DateTime dn = new DateTime(2016, 6, 8, 11, 49, 0);
// 从 DateTime 中获取日期不带时间
DateTime dateOnly = dn.Date;

Console.WriteLine("Complete date: " + dn.ToString("M/d/yyyy h:mm:ss tt"));

// 使用 d 格式说明符打印日期部分
Console.WriteLine("Short Date: " + dateOnly.ToString("M/d/yyyy"));

// 使用24小时制显示
Console.WriteLine("Display date using 24-hour clock format:");

// 使用 g 格式说明符打印短日期和时间
Console.WriteLine(dateOnly.ToString("M/d/yyyy h:mm tt"));

// 以 24 小时制以自定义格式显示日期和时间
Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));