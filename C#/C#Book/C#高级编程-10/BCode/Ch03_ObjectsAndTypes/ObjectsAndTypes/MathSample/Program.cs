
using static System.Console;

namespace MathSample;

class Program
{
 static void Main()
 {
  // Try calling some static functions.
  WriteLine($"Pi is {Math.GetPi()}");

  int x = Math.GetSquareOf(5);

  WriteLine($"Square of 5 is {x}");

  // Instantiate a Math object
  // instantiate a reference type 
  var math = new Math();
  math.Value = 30;

  WriteLine($"Value field of math variable contains {math.Value}");
  WriteLine($"Square of 30 is {math.GetSquare()}");
 }
}
