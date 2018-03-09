using System;

namespace Problem01CreditCardNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstGroup = int.Parse(Console.ReadLine());
            var secondGroup = int.Parse(Console.ReadLine());
            var thirdGroup = int.Parse(Console.ReadLine());
            var fourthGroup = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstGroup:D4} {secondGroup:D4} {thirdGroup:D4} {fourthGroup:D4}");
        }
    }
}