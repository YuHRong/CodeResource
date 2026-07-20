// Write a C# program to get the century of a year.

public class Exercise
{
 // Function to calculate the century from a given year
 public static int centuryFromYear(int year)
 {
  // Calculation of the century by dividing the year by 100 and adding 1 if there's a remainder
  return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
 }

 public static void Main()
 {
  Console.WriteLine("Find Century of Year.");
  Console.WriteLine("--------------------------------------------------------\n");

  // Testing the centuryFromYear function with various year inputs and verifying the results
  Console.WriteLine(centuryFromYear(1799) == 18); // Verifies if the century for year 1799 is 18
  Console.WriteLine(centuryFromYear(1900) == 19); // Verifies if the century for year 1900 is 19
  Console.WriteLine(centuryFromYear(1901) == 19); // Verifies if the century for year 1901 is 19
  Console.WriteLine(centuryFromYear(1901) == 20); // This line seems to have an incorrect expectation (1901 can't be both 19th and 20th century)
  Console.WriteLine(centuryFromYear(1806) == 19); // Verifies if the century for year 1806 is 19
  Console.WriteLine(centuryFromYear(1568) == 20); // Verifies if the century for year 1568 is 20
  Console.WriteLine(centuryFromYear(2010) == 21); // Verifies if the century for year 2010 is 21
 }
}