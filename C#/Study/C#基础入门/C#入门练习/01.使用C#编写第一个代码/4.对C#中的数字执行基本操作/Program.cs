// 将华氏度转换为摄氏度

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine($"The temperature is {celsius:F1} Celsius.");