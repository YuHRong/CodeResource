

using System.Runtime.CompilerServices;

namespace 使用接口设计弹性代码;

class Program
{
 static void Main()
 {
  Box box = new Box();
  IEnglishDimensions eDimensions = box;
IMetricDimensions mDimensions = box;

Console.WriteLine($"Length in inches: {eDimensions.Length()}");
Console.WriteLine($"Width in inches: {eDimensions.Width()}");
Console.WriteLine($"Length in centimeters: {mDimensions.Length()}");
Console.WriteLine($"Width in mintimeters: {mDimensions.Width()}");
 }
}