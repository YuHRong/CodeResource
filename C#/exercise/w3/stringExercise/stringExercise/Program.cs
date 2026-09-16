//Write a C# Sharp program to sort a string array in ascending order.

using System;

// Define the Exercise11 class
public class Exercise11
{
 // Main method - entry point of the program
 public static void Main()
 {
  string str; // Declare a string variable to hold user input
  char[] arr1; // Declare a character array
  char ch; // Declare a character variable
  int i, j, l; // Declare variables for iteration and string length

  // Prompt the user to input a string
  Console.Write("\n\nSort a string array in ascending order :\n");
  Console.Write("--------------------------------------------\n");
  Console.Write("Input the string : ");
  str = Console.ReadLine(); // Read the input string from the user
  l = str.Length; // Get the length of the input string
  arr1 = str.ToCharArray(0, l); // Convert the input string to a character array

  // Perform bubble sort to sort the character array in ascending order
  for (i = 1; i < l; i++)
  {
   for (j = 0; j < l - i; j++)
   for (j = 0; j < l - i; j++)
   for (j = 0; j < l - i; j++)
   {
    // Compare adjacent characters and swap them if they are in the wrong order
    if (arr1[j] > arr1[j + 1])
    {
     ch = arr1[j];
     arr1[j] = arr1[j + 1];
     arr1[j + 1] = ch;
    }
   }
  }

  // Display the sorted string
  Console.Write("After sorting the string appears like : \n");
  foreach (char c in arr1)
  {
   ch = c;
   Console.Write("{0} ", ch); // Print each character of the sorted array
  }
  Console.WriteLine("\n");
 }
}
