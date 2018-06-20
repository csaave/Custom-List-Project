using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_Item_To_List_Check_Count()
        {
            //arrange
            //object[] ArrayOfObjects = new Object[] {1,"3"};
            CustomList <int> list = new CustomList <int>();
            int expectedCount = 1;
            int value = 5;


            //assert
            list.Add(value);
            int ActualCount = list.count;

            //act
            Assert.AreEqual(expectedCount, ActualCount);


        }

        [TestMethod]
        public void Add_Item_To_List_Check_Index()
        {
            //arrange
            
            CustomList<int> list = new CustomList<int>();
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectValue = 3;

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);

            int actualValue = list[1];


            Assert.AreEqual(expectValue, actualValue);
            
          


        }
        [TestMethod]
        public void Remove_Item_From_List_Checks_Count()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedCount = 2;

            //act

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);

            int actualCount = list.count;

            Assert.AreEqual(expectedCount, actualCount);

        
        }
        [TestMethod]

        public void Remove_Item_From_List_Checks_Index()
        {
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 3;


            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(2);

            int actualValue = list[1];

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
