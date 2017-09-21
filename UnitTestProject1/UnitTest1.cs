using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ddOneNumber()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;
            //customlist = new customList

            // act

            list.Add(16);

            //assert
            Assert.AreEqual(expected, list[0]);
        }
        public void addTwoNumbers()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 20;

            //act 
            list.Add(16);
            list.Add(20);

            //assert
            Assert.AreEqual(expected, list[1]);
        }
        public void CheckZeroIndex()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            list.Add(16);
            list.Add(29);

            Assert.AreEqual(expected, list[0]);


        }
        public void removeOneNumber()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 0;

            list.Add(23);
            list.Remove(23);

            Assert.AreEqual(expected, list.count);
        }
        



    }
}

