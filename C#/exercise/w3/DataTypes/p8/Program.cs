// Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.

double radius, volume, surface;

Console.Write("Radius: ");
radius = Convert.ToDouble(Console.ReadLine());

surface = 4f * Math.Pow(radius, 2) * Math.PI;
volume = (4 / 3) * Math.Pow(radius, 3) * Math.PI;

Console.WriteLine(surface);
Console.WriteLine(volume);