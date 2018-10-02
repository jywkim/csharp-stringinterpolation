using System;

namespace csharp_stringinterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
          // double a = 3;
          // double b = 4;
          // Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
          // Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");
          //
          // double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);
          //
          // // Expected output:
          // // Area of the right triangle with legs of 3 and 4 is 6
          // // Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5
          //
          // var date = new DateTime(1731, 11, 25);
          // Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");
          //
          // // Expected output:
          // // On Sunday, November 25, 1731 Leonhard Euler introduced the letter e to denote 2.71828 in a letter to Christian Goldbach.

          const int NameAlignment = -9;
          const int ValueAlignment = 7;

          double a = 3;
          double b = 4;
          Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
          Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|");
          Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
          Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");

          // Expected output:
          // Three classical Pythagorean means of 3 and 4:
          // |Arithmetic|  3.500|
          // |Geometric|  3.464|
          // |Harmonic |  3.429|

          var xs = new int[] { 1, 2, 7, 9 };
          var ys = new int[] { 7, 9, 12 };
          Console.WriteLine($"Find the intersection of the {{{string.Join(", ",xs)}}} and {{{string.Join(", ",ys)}}} sets.");

          var userName = "Jon";
          var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
          var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
          Console.WriteLine(stringWithEscapes);
          Console.WriteLine(verbatimInterpolated);

          // Expected output:
          // Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
          // C:\Users\Jon\Documents
          // C:\Users\Jon\Documents
        }
    }
}
