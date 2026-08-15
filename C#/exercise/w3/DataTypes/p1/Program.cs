// Write a C# Sharp program that takes three letters and displays them in reverse order.

char ch1, ch2, ch3;

Console.Write("Input letter: ");
ch1 = Convert.ToChar(Console.ReadLine());

Console.Write("Input letter: ");
ch2 = Convert.ToChar(Console.ReadLine());

Console.Write("Input letter: ");
ch3 = Convert.ToChar(Console.ReadLine());

// Console.WriteLine("{0}{1}{2}", ch3, ch2, ch1);

Console.WriteLine($"{ch3}{ch2}{ch1}");