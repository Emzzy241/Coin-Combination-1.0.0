// =bn

using System;
using CoinCombos.Models;


namespace CoinCombos.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Coin combinations application");
            Console.WriteLine();
            Console.WriteLine("Enter an amount in cents:");
            try
            {
                int amount = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Coins userCoin = new Coins(0, 0, 0, 0);
                userCoin.CalculateCoinCombinationsRecursive(amount);
                Console.WriteLine("Your result is: ");
                Console.WriteLine("Quarters: " + userCoin.Quarter + "  Dimes: " + userCoin.Dime + "  Nickels: " + userCoin.Nickel + "  Pennies: " + userCoin.Penny);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you need to enter another amount? (Y/N)");
                string userInput = Console.ReadLine().ToUpper();
                if(userInput == "Y")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Main();
                }
                else if (userInput == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Goodbye");

                }
                else
                {
                    Console.WriteLine("Sorry I didn't get that, Please try again");
                    Console.WriteLine();
                    Console.WriteLine();
                    Main();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {0}", ex.Message);
                Console.WriteLine("Source = {0}", ex.Source);
                Console.WriteLine("StackTrace = {0}", ex.StackTrace);
                Console.WriteLine("TargetSite = {0}", ex.TargetSite);
                Console.WriteLine("Please e in numbers only");
            }
        }
    }
}