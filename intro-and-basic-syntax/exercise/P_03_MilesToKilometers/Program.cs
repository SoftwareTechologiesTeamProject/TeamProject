using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendet1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Receive from the console the length in kilometers
            double a = double.Parse(Console.ReadLine());

            // Clculate the length in miles
            double sum = a * 1.60934;

            // Write the result on the Console rounded to two digits after the decimal point
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
