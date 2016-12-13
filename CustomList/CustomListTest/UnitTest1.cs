using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTestIntPositives()
        {
            CustomList<int> apple = new CustomList<int>();
            int addToArray = 5;
            //act
            apple.Add(addToArray);
            //assert
            Assert.AreEqual(apple.blues.Length, 1);
        }
    }
}
