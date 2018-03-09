using System;

namespace Rectangle_Area
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //We receive from the Console the length for side a -> a double;
            int a = int.Parse(Console.ReadLine());
            //We receive from the Console the length for side b -> a double;
            double b = double.Parse(Console.ReadLine());
            //We calculate rectangle surface area;
            double area = a * b;
            //We print the output in the desired format;
            Console.WriteLine($"{area:f2}");
        }
    }
}