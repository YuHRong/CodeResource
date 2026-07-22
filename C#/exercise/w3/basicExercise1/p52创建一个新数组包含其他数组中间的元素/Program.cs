// Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

int[] arr1 = { 1, 2, 5 };
int[] arr2 = { 0, 3, 8 };
int[] arr3 = { -1, 0, 2 };

Console.WriteLine($"\nArray1: [{string.Join(", ", arr1)}]");
Console.WriteLine($"Array2: [{string.Join(", ", arr2)}]");
Console.WriteLine($"Array3: [{string.Join(", ", arr3)}]");

int[] newArr = { arr1[1], arr2[1], arr3[1] };

Console.WriteLine();
Console.WriteLine($"New array: [{string.Join(", ", newArr)}]");