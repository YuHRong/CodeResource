// Multiply Three Numbers
// Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.

int n1, n2, n3, product;

Console.Write("Input the first number to multiply: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Input the second number to multiply: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Input the third number to multiply: ");
n3 = int.Parse(Console.ReadLine());

product = n1 * n2 * n3;

Console.WriteLine($"{n1} x {n2} x {n3} = {product}\n");

// 另外一种打印方式
Console.WriteLine("{0} x {1} x {2} = {3}", n1, n2, n3, product);