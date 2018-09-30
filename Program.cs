using System;

namespace csharp_stringinterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
          double a = 3;
          double b = 4;
          Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
          Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

          double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

          // Expected output:
          // Area of the right triangle with legs of 3 and 4 is 6
          // Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5

          var date = new DateTime(1731, 11, 25);
          Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");

          // Expected output:
          // On Sunday, November 25, 1731 Leonhard Euler introduced the letter e to denote 2.71828 in a letter to Christian Goldbach.
        }
    }
}
