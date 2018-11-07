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
            int expected = 17;
            int actual;
            //Act
            list.Add(16);
            list.Add(17);
            actual = list[1];

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
            actual = list[999];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Remove() tests
        
        

    }
}
