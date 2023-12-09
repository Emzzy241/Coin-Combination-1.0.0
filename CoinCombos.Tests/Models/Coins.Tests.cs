using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombos.Models;
using System.Collections.Generic;
using System;

namespace CoinCombos.Tests
{
    [TestClass]
    public class CoinTests
    {   
        // 1st Test: correctly instantiate a new instance of the Coin constructo class
        [TestMethod]
        public void CoinConstructor_CreatesInstanceOfCoin_Coin()
        {
            Coins newCoin = new Coins(1, 3, 5, 7);
            Assert.AreEqual(typeof(Coins), newCoin.GetType());
        }

        // 2nd Test: Returns quarter value
        [TestMethod]
        public void GetQuarter_ReturnsQuarterValue_Int()
        {
            // Arrange 
            int expectedQuarterVal = 4;
            Coins newCoin = new Coins(4, 3, 5, 7);

            // Act
            int returnedQuarterVal = newCoin.Quarter;

            // Assert
            Assert.AreEqual(expectedQuarterVal, returnedQuarterVal);
        }

        // // 3rd Test: Sets quarter value
        [TestMethod]
        public void SetQuarter_SetsQuarterValue_Void()
        {
            // Arrange
            int setQuarterVal = 4;
            Coins newCoin = new Coins(6, 4, 5, 9);

            // Act
            newCoin.Quarter = setQuarterVal;

            // Assert
            Assert.AreEqual(setQuarterVal, newCoin.Quarter);
        }
        

        
        // 4th Test: Returns dime value
        [TestMethod]
        public void GetDime_ReturnsDimeValue_Int()
        {
            // Arrange 
            int expectedDimeVal = 3;
            Coins newCoin = new Coins(9, 3, 5, 7);

            // Act
            int returnedDimeVal = newCoin.Dime;

            // Assert
            Assert.AreEqual(expectedDimeVal, returnedDimeVal);
        }
        
        // 5th Test: Sets dime value
        [TestMethod]
        public void SetDime_SetsDimeValue_Void()
        {
            // Arrange
            int setDimeVal = 6;
            Coins newCoin = new Coins(3, 4, 5, 9);

            // Act
            newCoin.Dime = setDimeVal;

            // Assert
            Assert.AreEqual(setDimeVal, newCoin.Dime);
        }
        
        
        // 6th Test: Returns nickel value
        [TestMethod]
        public void GetNickel_ReturnsNickelValue_Int()
        {
            // Arrange 
            Coins newCoin = new Coins(1, 3, 5, 7);
            int expectedNickelVal = 5;

            // Act
            int returnedNickelVal = newCoin.Nickel;

            // Assert
            Assert.AreEqual(expectedNickelVal, returnedNickelVal);
        }
        
        // 7th Test: Sets nickel value
        [TestMethod]
        public void SetNickel_SetsNickelValue_Void()
        {
            // Arrange
            int setNickelVal = 6;
            Coins newCoin = new Coins(3, 4, 5, 9);

            // Act
            newCoin.Nickel = setNickelVal;

            // Assert
            Assert.AreEqual(setNickelVal, newCoin.Nickel);
        }
        
        
        // 8th Test: Returns penny value
        [TestMethod]
        public void GetPenny_ReturnsPennyValue_Int()
        {
            // Arrange 
            Coins newCoin = new Coins(1, 3, 5, 7);
            int expectedPennyVal = 0;

            // Act
            int returnedPennyVal = newCoin.Penny;

            // Assert
            Assert.AreEqual(expectedPennyVal, returnedPennyVal);
        }

        
        // 9th Test: Sets nickel value
        // [TestMethod]
        // public void SetPenny_SetsPennyValue_Void()
        // {
        //     // Arrange
        //     int setPennyVal = 10;
        //     Coins newCoin = new Coins(3, 4, 5, 9);

        //     // Act
        //     newCoin.Penny = setPennyVal;

        //     // Assert
        //     Assert.AreEqual(setPennyVal, newCoin.Penny);
        // }
        
        // 6th Test: Calcuates the coin combinations
        // First path: if the change in cents is greater than 25
        // [TestMethod]
        // public void CalculateCoinCombinationsRecursive_CalculatesIfCentsChangeIsGreaterThan25_Void()
        // {
        //     // Arrange 
        //     int changeValue = 25;
        //     Coins newCoin = new Coins(changeValue, 3, 5, 7);
        //     int expectedChangeValInQuarter = 1;

        //     // Act
        //     int returnedChangeVal = newCoin.CalculateCoinCombinationsRecursive();

        //     // Assert
        //     Assert.AreEqual(expectedChangeValInQuarter, returnedChangeVal);
        // }

        
    }
}