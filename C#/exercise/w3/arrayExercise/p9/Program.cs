// Write a C# Sharp program to find the maximum and minimum elements in an array.

const int len = 100;
int[] arr = new int[len];
int n, minValue, maxValue;
minValue = maxValue = 0;
maxValue = 0;

Console.Write("\n\nFind maximum and minimum element in an array :\n");
Console.Write("--------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array:");
for (int i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
 if (i == 0)
 {
  minValue = arr[i];
  maxValue = arr[i];
 }
 else
 {
  if (arr[i] < minValue)
  {
   minValue = arr[i];
  }
  if (arr[i] > maxValue)
  {
   maxValue = arr[i];
  }
 }
}

Console.WriteLine($"Maximum element is : {maxValue}");
Console.WriteLine($"Minimum element is : {minValue}");