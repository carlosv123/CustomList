using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_One_Number()
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
        public void Add_Two_Numbers()
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
        public void Check_Zero_Index()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            list.Add(16);
            list.Add(29);

            Assert.AreEqual(expected, list[0]);


        }
        [TestMethod]
        public void Add_String()
        {
            CustomList<string> stringList = new CustomList<string>();
            string expected = "bottle";

            stringList.Add("bottle");

            Assert.AreEqual(expected, stringList[0]);

        }
        [TestMethod]
        public void Remove_OneNumber()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 0;

            list.Add(23);
            list.Remove(23);

            Assert.AreEqual(expected, list.count);
        }
        [TestMethod]
        public void Remove_OneNumber_From_List()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            list.Add(1);
            list.Add(2);
            list.Remove(2);

            Assert.AreEqual(expected, list.count);
        }
        [TestMethod]
        public void Remove_OneInt_IntNotInLiist()
        {
            CustomList<int> list = new CustomList<int>();
            bool expected = false;

            list.Add(1);
            list.Add(2);
            list.Remove(2);
            foreach(var item in list)
            {
                if(item == 2)
                {
                    expected = true;
                }
            }
            Assert.IsFalse(expected);
        }
        [TestMethod]
        public void Remove_One_String()
        {
            CustomList<string> listString = new CustomList<string>();
            string expected = "hey";

            listString.Add("hey");
            listString.Remove("hey");

            Assert.AreEqual(expected, listString[]);
         }
        [TestMethod]
        public void Over_Ride_ToString()
        {
            CustomList<string> newString = new CustomList<string>();
            newString.Add("hello");
            newString.Add("world");

            string expected = ("hello world");
            string actualresult = newString.ToString();

            Assert.AreEqual(expected, actualresult);
        }
        [TestMethod]
        public void Over_Load_Plus_Operator()
        {
            CustomList<string> one = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> three = new CustomList<string>();

            one.Add("hello");
            Two.Add("world");

            string expected = ("hello world");
            CustomList<string> actualresult = one + Two;
            // three = one + two;

            Assert.AreEqual(expected, actualresult);
        }
        [TestMethod]
        public void Over_Load_Minus_Operator()
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
        public void Zip_Test()
        {
            CustomList<string> One = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();

            One.Add("he", "go", "mor");
            two.Add("llo", "ood", "ning");

            string expected =("hello", "good", "morning");
            int actualresult = zip();

            Assert.AreEqual(expected, zip());
        }


    }
}

