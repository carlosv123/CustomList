using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addOneNumber()
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
        [TestMethod]
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
        [TestMethod]
        public void CheckZeroIndex()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            list.Add(16);
            list.Add(29);

            Assert.AreEqual(expected, list[0]);


        }
        [TestMethod]
        public void addString()
        {
            CustomList<string> stringList = new CustomList<string>();
            string expected = "bottle";

            stringList.Add("bottle");

            Assert.AreEqual(expected, stringList[0]);

        }
        [TestMethod]
        public void removeOneNumber()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 0;

            list.Add(23);
            list.Remove(23);

            Assert.AreEqual(expected, list.count);
        }
        [TestMethod]
        public void removeOneNumberFromList()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            list.Add(1);
            list.Add(2);
            list.Remove(2);

            Assert.AreEqual(expected, list.count);
        }
        [TestMethod]
        public void removeOneString()
        {
            CustomList<string> listString = new CustomList<string>();
            string expected = "hey";

            listString.Add("hey");
            listString.Remove("hey");

            Assert.AreEqual(expected, listString.count);
         }
        [TestMethod]
        public void overrideToString()
        {
            CustomList<String> newString = new CustomList<string>();
            newString.Add("hello");
            newString.Add("world");

            string expected = ("hello world");
            string actualresult = newString.ToString();

            Assert.AreEqual(expected, actualresult);
        }
        [TestMethod]
        public void overloadPlusOperator()
        {
            CustomList<string> one = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> three = new CustomList<string>();

            one.Add("hello");
            Two.Add("world");

            string expected = ("hello world");
            string actualresult = one + Two;
            // three = one + two;

            Assert.AreEqual(expected, actualresult);
        }
        [TestMethod]
        public void overloadMinusOperator()
        {
            CustomList<int> onelist = new CustomList<int>();
            CustomList<int> twolist = new CustomList<int>();

            onelist.Add(20);
            twolist.Add(10);

            int expected = (10);
            int actualresult = onelist - twolist;
            //onelist -= twolist;

            Assert.AreEqual(expected, actualresult);
        }
        [TestMethod]
        public void zipTest()
        {
            CustomList<int> number = new CustomList<int>();
            CustomList<string> strings = new CustomList<string>();

            strings.Add("one", "two", "three");
            number.Add(1, 2, 3);

            int expected = (1,"one",2,"two",3,"three");
            int actualresult = number + strings;

            Assert.AreEqual(expected, actualresult);
            


            

 
        }
        
        

         



    }
}

