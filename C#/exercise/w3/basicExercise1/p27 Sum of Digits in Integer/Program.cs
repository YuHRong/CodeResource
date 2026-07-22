// Sum of Digits in Integer
// Write a C# program and compute the sum of an integer's digits.

int num, sum = 0;

Console.Write("Input a intger: ");
num = Convert.ToInt32(Console.ReadLine());

while (num != 0)
{
 sum += num % 10;
 num /= 10;
}

Console.WriteLine(sum);