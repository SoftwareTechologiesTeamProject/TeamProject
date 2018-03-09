using System;

namespace Problem01CreditCardNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // We recive groups of numbers
            var firstGroup = int.Parse(Console.ReadLine());
            var secondGroup = int.Parse(Console.ReadLine());
            var thirdGroup = int.Parse(Console.ReadLine());
            var fourthGroup = int.Parse(Console.ReadLine());

            // Print the credit card number
            Console.WriteLine($"{firstGroup:D4} {secondGroup:D4} {thirdGroup:D4} {fourthGroup:D4}");
        }
    }
}