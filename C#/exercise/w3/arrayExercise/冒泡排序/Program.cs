int[] arr1 = { 3, 4, 2, 5, 7, 1, 9 };
int n = arr1.Length;

for (int i = 0; i < n - 1; i++)
{
 for (int j = 0; j < n - 1 - i; j++)
 {
  if (arr1[j] > arr1[j + 1])
  {
   int temp = arr1[j];
   arr1[j] = arr1[j + 1];
   arr1[j + 1] = temp;
  }
 }
}

for (int i = 0; i < n; i++)
{
 Console.Write(arr1 + " ");
}

Console.WriteLine();

Console.ReadKey();