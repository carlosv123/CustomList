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

    }
}

