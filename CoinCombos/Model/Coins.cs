using System;

namespace CoinCombos.Models
{
    public class Coins
    {
        // Key notables: 
        // User is entering in a certain amount of cents andc our application shows the smallest numbers of quarters, dimes, nickels and pennies needed to make that change

        // A penny is also known as a cent
        // 5 cents = 1 nickel
        // 10 cents = 1 dime or equivalent to 2 nickels
        // 25 cents = 1 quarter or equivalent to 5 nickels, or 2 dimes 1 nickel or 2 dimes 1 cent
        // 6 cents = 1 nickel, 1 penny
        // 28 cents = 1 quarter, 3  pennies
        // 74 = 2 quarters, 2 dimes, 4 pennies

        // auto-implemented properties for my nickel, dime, quarter
       
        public int Quarter { get; set; }
        public int Dime { get; set; }
        public int Nickel { get; set; }
        public int Penny { get; set; }

        public Coins(int myQuarter, int myDime, int myNickel, int myPenny)
        {
            Quarter  = myQuarter;
            Dime = myDime;
            Nickel = myNickel;
            Penny = myPenny;
        }

        // Writing a recursive method.... Whose purpose will be to keep calculating the exact value of our change
        // Recursives are methods/functions we call inside itself

        public void CalculateCoinCombinationsRecursive(int amount)
        {
            if(amount >= 25)
            {
                Quarter++;
                // amount -= 25;
            }
        }

        
        
        


    }
}