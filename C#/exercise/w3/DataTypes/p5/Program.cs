// Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.

double radius, perimeter, area; ;


Console.Write("Input the radius of the circle :");
radius = Convert.ToDouble(Console.ReadLine());

perimeter = 2 * radius * Math.PI;
area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Perimeter of circle : {perimeter:F2}");
Console.WriteLine($"Area of Circle : {area:F2}");