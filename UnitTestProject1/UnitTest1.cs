﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToList_IfIntAdded_GoesUpByOne()
        {
            BriansList<int> list = new BriansList<int>();
            //arrange
            int expected = 1;
            //act
            list.Add(16);
            int actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_IfIndexOneIsAdded_IntAddedAtIndexOne()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            int expected = 3;
            //Act
            list.Add(2);
            list.Add(3);
            int actual = list[1];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_WhenANewIndexAdded_ZeroIndexRemains()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            int expected = 16;
            int actual;
            //Act
            list.Add(16);
            list.Add(17);
            actual = list[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_AddOneThousand_GetIndexNineNinetyNine()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            int expected = 1000;
            int actual;
            //Act
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
            actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToList_AddFifteen_GetIndexFourteen()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            int expected = 14;
            int actual;
            //Act
            for (int i = 0; i < 15; i++)
            {
                list.Add(i);
            }
            actual = list[14];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Remove() tests
        [TestMethod]
        public void RemoveFromList_IfIndexRemoved_ListOneCountLess()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 3;
            //Act
            list.Remove(2);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFromList_IfIndexReferenced_MakeSureIndexRemoved()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            int expected = 4;
            //Act
            list.Remove(3);
            int actual = list[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void RemoveFromList_IfRemoveSameNumber_AllInstancesRemoved()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(1);

            int expected = 3;
            //Act
            list.Remove(1);
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RemoveFromList_RemoveWholeList()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            int expected = 0;
            //Act
            for (int i = list.Count -1; i >= 0; i--)
            {
                list.Remove(list[i]);
            }
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFromList_IfRemovingNothing_SameListReturns()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected = 4;
            //Act
            list.Remove(0); //as in, no zero value to find
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
         //overloaded operator+
        [TestMethod]
        public void OverloadPlus_IfTwoEqualListsAdded_LastIndexChecksOut()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            int expected = 6;
            //Act
            BriansList<int> newList = listOne + listTwo; //creates newList
            int actual = newList[5];
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OverloadPlus_IfTwoEqualListsAdded_LisCountChecksOut()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            int expected = 6;
            //Act
            BriansList<int> newList = listOne + listTwo;
            int actual = newList.Count;
            //Assert    
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void OverloadPlus_IfTwoEqualListsAdded_CheckFullArray()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            //Act
            BriansList<int> newList = listOne + listTwo;
            int[] actual = newList.arr; 
            //Assert    
            Assert.ReferenceEquals(expected, actual);

        }

        [TestMethod]
        public void OverloadMinus_IfPreviousListSubtracted_SubtractListquantity()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> listToSubtract = listOne;
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            BriansList<int> newList = listOne + listTwo;
            int expected = 3;
            //Act
            BriansList<int> reducedList = newList - listOne;
            int actual = reducedList.Count;
            //Assert    
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadMinus_IfPreviousListSubtracted_IndexesMatch()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> listToSubtract = listOne;
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            BriansList<int> newList = listOne + listTwo;
            int expected = 4;
            //Act
            BriansList<int> reducedList = newList - listOne;
            int actual = reducedList[0];
            //Assert    
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OverloadMinus_IfSecondListSubtracted_IndexesMatch()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> listToSubtract = listOne;
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            BriansList<int> newList = listOne + listTwo;
            int expected = 2;
            //Act
            BriansList<int> reducedList = newList - listTwo;
            int actual = reducedList[1];
            //Assert    
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_IfListBrokenDownToStrings_ToStrings()
        {
            //Arrange
            BriansList<int> list = new BriansList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            string expected = "1234";
            
            //Act
            
            string actual = list.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListZipper_IfTwoEqualListsProvided_NewZipperedList()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> zippedList = new BriansList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            int expected = 6;
            //Act
            zippedList.ListZipper(listOne, listTwo);
            int actual = zippedList[5];
            //Assert    
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ListZipper_IfTwoEqualListsProvided_ChecksForFullList()
        {
            //Arrange
            BriansList<int> listOne = new BriansList<int>();
            BriansList<int> listTwo = new BriansList<int>();
            BriansList<int> zippedList = new BriansList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            int[] expected = { 1, 4, 2, 5, 3, 6 };
            //Act
            zippedList.ListZipper(listOne, listTwo);
            int[] actual = zippedList.arr;
            //Assert    
            Assert.ReferenceEquals(expected, actual);

        }

    }
}
