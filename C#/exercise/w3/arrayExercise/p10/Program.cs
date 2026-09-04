// Write a program in C# Sharp to separate odd and even integers into separate arrays.

const int len = 50;
int[] arr = new int[len];
int[] evenArr = new int[len];
int[] oddArr = new int[len];
int j = 0, k = 0;

Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
Console.Write("------------------------------------------------------\n");

Console.Write("Input the number of elements to be stored in the array :");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} elements in the array :");
for (int i = 0; i < n; i++)
{
 Console.Write($"element - {i} : ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
 if (arr[i] % 2 == 0)
 {
  evenArr[j] = arr[i];
  j++;
 }
 else
 {
  oddArr[k] = arr[i];
  k++;
 }
}

Console.WriteLine("The Even elements are:");
for (int i = 0; i < j; i++)
{
 Console.Write($"{evenArr[i]} ");
}
Console.WriteLine();

Console.WriteLine("The Odd elements are: ");
for (int i = 0; i < k; i++)
{
 Console.Write($"{oddArr[i]} ");
}
Console.WriteLine();