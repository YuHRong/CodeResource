// 申明不同类型的可空变量

int? num1 = null;
int? num2 = 45;
double? num3 = new double?();
double? num4 = 3.14157;
bool? boolVal = new bool?();    // null

// 显示值（null 会显示为空字符串）
Console.WriteLine($"num1 = {num1 ?? 0}");         // 0
Console.WriteLine($"num2 = {num2 ?? 0}");         // 45
Console.WriteLine($"num3 = {num3 ?? 0.0}");       // 0
Console.WriteLine($"num4 = {num4 ?? 0.0}");       // 3.14157
Console.WriteLine($"boolVal = {boolVal}");         // （空）
