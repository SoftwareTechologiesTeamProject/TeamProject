//CONFIRMED from <prohause>
using System;

namespace P_03_MilesToKilometers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Receive from the console the length in kilometers
            double distanceInKilometers = double.Parse(Console.ReadLine());

            // Clculate the length in miles
            double sum = distanceInKilometers * 1.60934;

            // Write the result on the Console rounded to two digits after the decimal point
            Console.WriteLine("{0:F2}", sum);
        }
    }
}