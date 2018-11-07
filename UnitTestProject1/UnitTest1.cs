using System;
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

            int expected = 1;
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
            int expected = 0;
            //Act
            for (int i = 0; i < list.Count; i++)
            {
                list.Remove(i);
            }
            int actual = list.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        

    }
}
