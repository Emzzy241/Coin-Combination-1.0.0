// =bn

using System;
using CoinCombos.Models;


namespace CoinCombos.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an amount:");
            int amount = int.Parse(Console.ReadLine());
            CoinCombinations coins = new CoinCombinations();
            coins.CalculateCombinationsRecursive(amount);
            Console.WriteLine("Quarters: " + coins.GetQuarters() + "  Dimes: " + coins.GetDimes() + "  Nickels: " + coins.GetNickels() + "  Pennies: " + coins.GetPennies());
            Console.WriteLine("Do you need to enter another amount? (Y/N)");
            string userInput = Console.ReadLine();
            if(userInput == "Y" || userInput == "y")
            {
                Main();
            }
        }
    }
}