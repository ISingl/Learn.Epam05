using System;
using TaskVector;
namespace Vector_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Application for working with vectors";

            Console.Write($"{appName}\n{new string('=', appName.Length)}\n" +
                $"Enter the x, y, z coordinates using a space for the vector a: ");
            var arg = ConsoleInput();
            Vector vectorA = new Vector(arg[0], arg[1], arg[2]);

            Console.Write($"Enter the x, y, z coordinates using a space for the vector b: ");
            arg = ConsoleInput();
            Vector vectorB = new Vector(arg[0], arg[1], arg[2]);

            Console.Write("Enter the number to multiply: ");
            if(!double.TryParse(Console.ReadLine(), out double n)) throw new ArgumentException("Incorrect data");

            Console.WriteLine($"\nThe sum of vectors:\n" +
                $"vector a{vectorA} + vector b{vectorB} = vector c{vectorA + vectorB}");
            Console.WriteLine($"\nThe difference of vectors:\n" +
                $"vector a{vectorA} - vector b{vectorB} = vector c{vectorA - vectorB}");
            Console.WriteLine($"\nScalar multiplication of vectors:\n" +
                $"vector a{vectorA} * vector b{vectorB} = {vectorA * vectorB}");
            Console.WriteLine($"\nVector multiplication of vectors:\n" +
                $"vector a{vectorA} ^ vector b{vectorB} = vector c{vectorA ^ vectorB}");
            Console.WriteLine($"\nMultiplying a vector by a number:\n" +
                $"vector a * {n} = vector a{vectorA * n}");
            Console.WriteLine($"\nInverse vector a{vectorA} = vector a{-vectorA}");
            Console.WriteLine($"\nThe module of vector a{vectorA} = {!vectorA}");

            Console.ReadLine();
        }

        static double[] ConsoleInput()
        {
            double[] tmp = new double[3];
            var inVectA = Console.ReadLine().Split(' ');
            if (inVectA.Length == 3 &&
                double.TryParse(inVectA[0], out tmp[0]) &&
                double.TryParse(inVectA[1], out tmp[1]) &&
                double.TryParse(inVectA[2], out tmp[2]))
            {
                return tmp;
            }
            else
            {
                throw new ArgumentException("Incorrect data");
            }
        }
    }
}
