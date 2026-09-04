// Write a C# Sharp program to sort array elements in descending order.

// Write a C# Sharp program to sort elements of an array in ascending order.

const int len = 100;
int[] arr = new int[len];
int n, temp;

Console.Write("\n\nsort elements of array in descending order :\n");
Console.Write("----------------------------------------------\n");

Console.Write("Input the size of array : ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array :");
for (int i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
 for (int j = 0; j < n; j++)
 {
  if (arr[i] > arr[j])
  {
   temp = arr[i];
   arr[i] = arr[j];
   arr[j] = temp;
  }
 }
}

Console.WriteLine("Elements of array in sorted ascending order:");
for (int i = 0; i < n; i++)
 Console.Write($"{arr[i]} ");
Console.WriteLine();