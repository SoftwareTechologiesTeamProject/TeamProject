using System;

namespace Problem01CreditCardNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // We recive groups of numbers
            int firstGroupChanged = int.Parse(Console.ReadLine());
            int secondGroup = int.Parse(Console.ReadLine());
            int thirdGroup = double.Parse(Console.ReadLine());
            int fourthGroup = int.Parse(Console.ReadLine());

            // Print the credit card number
            Console.WriteLine($"{firstGroupChanged:D4} {secondGroup:D4} {thirdGroup:D4} {fourthGroup:D4}");
        }
    }
}