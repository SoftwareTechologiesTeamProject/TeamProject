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


            double a = double.Parse(Console.ReadLine());
            double sum = a * 1.60934;


            Console.WriteLine("{0:F2}", sum);
        }
    }
}
