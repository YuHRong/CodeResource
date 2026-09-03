// Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.

float h, m, s;    // 申明时间变量，小时，分钟，秒
float metresSec, kmH, mileH;   // 申明保存距离/时间变量
float distance, timeSeconds;

Console.Write("Input distance(metres): ");
distance = Convert.ToSingle(Console.ReadLine());
Console.Write("Input time seconds(hour) : ");
h = Convert.ToSingle(Console.ReadLine());
Console.Write("Input time seconds(minute) : ");
m = Convert.ToSingle(Console.ReadLine());
Console.Write("Input time seconds(seconds) : ");
s = Convert.ToSingle(Console.ReadLine());

timeSeconds = (h * 3600) + (m * 60) + s;

metresSec = distance / timeSeconds;
kmH = (distance / 1000.0f) / ( timeSeconds / 3600.0f);
mileH = kmH / 1.609f;

Console.WriteLine($"Your speed in metres/sec is {metresSec}");
Console.WriteLine($"Your speed in km/h is {kmH}");
Console.WriteLine($"Your speed in miles/h is {mileH}");
