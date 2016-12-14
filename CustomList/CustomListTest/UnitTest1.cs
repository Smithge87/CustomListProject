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
            CustomList<int> numbers = new CustomList<int>();
            int addFirst = 5;
            int addSecond = 8;
            //act
            numbers.Add(addFirst);
            numbers.Add(addSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], 5);
            Assert.AreEqual(numbers.customArray[1], 8);
        }
        [TestMethod]
        public void AddTestIntNegatives()
        {
            CustomList<int> numbers = new CustomList<int>();
            int addFirst = -5;
            int addSecond = -8;
            //act
            numbers.Add(addFirst);
            numbers.Add(addSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], -5);
            Assert.AreEqual(numbers.customArray[1], -8);
        }
        [TestMethod]
        public void AddTestIntZero()
        {
            CustomList<int> numbers = new CustomList<int>();
            int addFirst = 5;
            int addSecond = 0;
            //act
            numbers.Add(addFirst);
            numbers.Add(addSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], 5);
            Assert.AreEqual(numbers.customArray[1], 0);
        }
        [TestMethod]
        public void AddTestIntSameNumber()
        {
            CustomList<int> numbers = new CustomList<int>();
            int addFirst = 5;
            int addSecond = 5;
            //act
            numbers.Add(addFirst);
            numbers.Add(addSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], 5);
            Assert.AreEqual(numbers.customArray[1], 5);
        }
        [TestMethod]
        public void AddTestIntMax()
        {
            CustomList<int> numbers = new CustomList<int>();
            int addFirst = 2147483647;
            int addSecond = 8;
            //act
            numbers.Add(addFirst);
            numbers.Add(addSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], 2147483647);
            Assert.AreEqual(numbers.customArray[1], 8);
        }
        [TestMethod]
        public void AddTestStrings()
        {
            CustomList<string> words = new CustomList<string>();
            string addFirst = "dog";
            string addSecond = "cat";
            //act
            words.Add(addFirst);
            words.Add(addSecond);
            //assert
            Assert.AreEqual(words.customArray.Length, 2);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[1], "cat");
        }
        [TestMethod]
        public void AddTestDoublesPos()
        {
            CustomList<double> doubles = new CustomList<double>();
            double addFirst = 1.98;
            double addSecond = 2.45;
            //act
            doubles.Add(addFirst);
            doubles.Add(addSecond);
            //assert
            Assert.AreEqual(doubles.customArray.Length, 2);
            Assert.AreEqual(doubles.customArray[0], 1.98);
            Assert.AreEqual(doubles.customArray[1], 2.45);
        }
        [TestMethod]
        public void AddTestDoublesNeg()
        {
            CustomList<double> doubles = new CustomList<double>();
            double addFirst = -1.98;
            double addSecond = -2.45;
            //act
            doubles.Add(addFirst);
            doubles.Add(addSecond);
            //assert
            Assert.AreEqual(doubles.customArray.Length, 2);
            Assert.AreEqual(doubles.customArray[0], -1.98);
            Assert.AreEqual(doubles.customArray[1], -2.45);
        }
        [TestMethod]
        public void AddTestDoublesZero()
        {
            CustomList<double> doubles = new CustomList<double>();
            double addFirst = 0;
            double addSecond = -2.45;
            //act
            doubles.Add(addFirst);
            doubles.Add(addSecond);
            //assert
            Assert.AreEqual(doubles.customArray.Length, 2);
            Assert.AreEqual(doubles.customArray[0], 0);
            Assert.AreEqual(doubles.customArray[1], -2.45);
        }
        [TestMethod]
        public void AddTestDoublesMax()
        {
            CustomList<double> doubles = new CustomList<double>();
            double addFirst = -1.987654321;
            double addSecond = -2.45;
            //act
            doubles.Add(addFirst);
            doubles.Add(addSecond);
            //assert
            Assert.AreEqual(doubles.customArray.Length, 2);
            Assert.AreEqual(doubles.customArray[0], -1.987654321);
            Assert.AreEqual(doubles.customArray[1], -2.45);
        }
        [TestMethod]
        public void RemoveTestIntNegatives()
        {
            CustomList<int> numbers = new CustomList<int>();
            int removeFirst = -3;
            int removeSecond = -8;
            //act
            numbers.Add(-3);
            numbers.Add(-8);
            numbers.Add(-9);
            numbers.Remove(removeFirst);
            numbers.Remove(removeSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 1);
            Assert.AreEqual(numbers.customArray[0], -9);
        }
        [TestMethod]
        public void RemoveTestIntZeros()
        {
            CustomList<int> numbers = new CustomList<int>();
            int removeFirst = 0;
            int removeSecond = -8;
            //act
            numbers.Add(9);
            numbers.Add(-8);
            numbers.Add(0);
            numbers.Remove(removeFirst);
            numbers.Remove(removeSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 1);
            Assert.AreEqual(numbers.customArray[0], 9);
        }
        [TestMethod]
        public void RemoveTestIntMax()
        {
            CustomList<int> numbers = new CustomList<int>();
            int removeFirst = 2147483647;
            int removeSecond = -8;
            //act
            numbers.Add(-3);
            numbers.Add(-8);
            numbers.Add(2147483647);
            numbers.Remove(removeFirst);
            numbers.Remove(removeSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 1);
            Assert.AreEqual(numbers.customArray[0], -3);
        }
        [TestMethod]
        public void RemoveTestIntoOneSame()
        {
            CustomList<int> numbers = new CustomList<int>();
            int removeFirst = 21;
            //act
            numbers.Add(-3);
            numbers.Add(21);
            numbers.Add(21);
            numbers.Remove(removeFirst);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 2);
            Assert.AreEqual(numbers.customArray[0], -3);
            Assert.AreEqual(numbers.customArray[1], 21);
        }
        [TestMethod]
        public void RemoveTestIntoTwoSame()
        {
            CustomList<int> numbers = new CustomList<int>();
            int removeFirst = 21;
            int removeSecond = 21;
            //act
            numbers.Add(-3);
            numbers.Add(21);
            numbers.Add(21);
            numbers.Remove(removeFirst);
            numbers.Remove(removeSecond);
            //assert
            Assert.AreEqual(numbers.customArray.Length, 1);
            Assert.AreEqual(numbers.customArray[0], -3);
        }
        [TestMethod]
        public void RemoveTestString()
        {
            CustomList<string> words = new CustomList<string>();
            string removeFirst = "cat";
            //act
            words.Add("cat");
            words.Add("dog");
            words.Add("fish");
            words.Remove(removeFirst);
            //assert
            Assert.AreEqual(words.customArray.Length, 2);
            Assert.AreEqual(words.customArray[0], -3);
            Assert.AreEqual(words.customArray[1], 21);
        }
    }
}