using System;

namespace Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Wrong number of arguments. Use: triangle.exe <num1> <num2> <num3>");
                return;
            }

            if (double.TryParse(args[0], out double a) && double.TryParse(args[1], out double b) && double.TryParse(args[2], out double c))
            {
                string result = GetTriangleType(a, b, c);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static string GetTriangleType(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Не треугольник";
            }

            else if (a == b && b == c)
            {
                return "Равносторонний";
            }

            else if (a == b || a == c || b == c)
            {
                return "Равнобедренный";
            }

            return "Обычный";
        }
    }
}