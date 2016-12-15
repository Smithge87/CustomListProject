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
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[1], "fish");
        }
        [TestMethod]
        public void RemoveTestStringDoubles()
        {
            CustomList<string> words = new CustomList<string>();
            string removeFirst = "cat";
            //act
            words.Add("cat");
            words.Add("dog");
            words.Add("fish");
            words.Add("cat");
            words.Remove(removeFirst);
            //assert
            Assert.AreEqual(words.customArray.Length, 3);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[2], "cat");

        }
        [TestMethod]
        public void RemoveTestStringNothingRemovable()
        {
            // NEED TO CHECK IF CUSTOM-ARRAY CONTAINS THE VALUE TO BE REMOVED FIRST. OVERLOADING NEW ARRAY.
            CustomList<string> words = new CustomList<string>();
            string removeFirst = "cat";
            //act
            words.Add("dog");
            words.Add("fish");
            words.Remove(removeFirst);
            //assert
            Assert.AreEqual(words.customArray.Length, 2);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[1], "fish");
        }
        [TestMethod]
        public void RemoveTestStringTwoRemovalsSame()
        {
            CustomList<string> words = new CustomList<string>();
            string removeFirst = "cat";
            string removeSecond = "cat";
            //act
            words.Add("cat");
            words.Add("dog");
            words.Add("fish");
            words.Add("cat");
            words.Remove(removeFirst);
            words.Remove(removeSecond);
            //assert
            Assert.AreEqual(words.customArray.Length, 2);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[1], "fish");
        }
        [TestMethod]
        public void RemoveTestStringTwoRemovalsDifferent()
        {
            CustomList<string> words = new CustomList<string>();
            string removeFirst = "cat";
            string removeSecond = "dog";
            //act
            words.Add("cat");
            words.Add("dog");
            words.Add("fish");
            words.Add("cat");
            words.Remove(removeFirst);
            words.Remove(removeSecond);
            //assert
            Assert.AreEqual(words.customArray.Length, 2);
            Assert.AreEqual(words.customArray[1], "cat");
            Assert.AreEqual(words.customArray[0], "fish");
        }
        [TestMethod]
        public void CustomListCreationTestIntEmpty()
        {
            //act
            CustomList<int> numbers = new CustomList<int>();
            //assert
            Assert.AreEqual(numbers.customArray.Length, 0);
        }
        [TestMethod]
        public void CustomListCreationTestStringEmpty()
        {
            //act
            CustomList<string> words = new CustomList<string>();
            //assert
            Assert.AreEqual(words.customArray.Length, 0);
        }
        [TestMethod]
        public void CustomListCreationTestIntFilled()
        {
            //act
            CustomList<int> numbers = new CustomList<int>() { 0, 1, 2, 3, 4, 5 };
            //assert
            Assert.AreEqual(numbers.customArray.Length, 6);
            Assert.AreEqual(numbers.customArray[4], 4);
        }
        [TestMethod]
        public void CustomListCreationTestDouble()
        {
            //act
            CustomList<double> doubles = new CustomList<double>();
            //assert
            Assert.AreEqual(doubles.customArray.Length, 0);
        }
        [TestMethod]
        public void CustomListCreationTestStringFilled()
        {
            //act
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };
            //assert
            Assert.AreEqual(words.customArray.Length, 4);
            Assert.AreEqual(words.customArray[3], "bee");
        }
        [TestMethod]
        public void CountTestStrings()
        {
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };

            //act
            int result = words.Count;
            //assert
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void CountTestInts()
        {
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 4, 5, };

            //act
            int result = numbers.Count;
            //assert
            Assert.AreEqual(result, 5);
        }
        [TestMethod]
        public void CountTestStringsWrong()
        {
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };

            //act
            int result = words.Count;
            //assert
            Assert.AreEqual(result, 4);
            Assert.AreNotEqual(result, 5);
            Assert.AreNotEqual(result, 3);
        }
        [TestMethod]
        public void CountTestDouble()
        {
            CustomList<double> doubles = new CustomList<double>() { 3446657, 0, .9425, 3856362 };

            //act
            int result = doubles.Count;
            //assert
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void CountTestEmpty()
        {
            CustomList<double> doubles = new CustomList<double>();

            //act
            int result = doubles.Count;
            //assert
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void CountTestLarge()
        {
            CustomList<double> doubles = new CustomList<double>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //act
            int result = doubles.Count;
            //assert
            Assert.AreEqual(result, 139);
        }
        [TestMethod]
        public void OperatorPlusTestStrings()
        {
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };
            CustomList<string> wordy = new CustomList<string>() { "cat", "dog", "bat", "bee" };

            //act
            words = words + wordy;
            //assert
            Assert.AreEqual(words.Count, 8);
            Assert.AreEqual(words.customArray[2], "bat");
            Assert.AreEqual(words.customArray[7], "bee");
        }
        [TestMethod]
        public void OperatorPlusTestInts()
        {
            CustomList<int> numbers = new CustomList<int>() { 1,2,3,4,5,6,7,8,9,0 };
            CustomList<int> numbered = new CustomList<int>() {1,2,3};

            //act
            numbers = numbers + numbered;
            //assert
            Assert.AreEqual(numbers.Count, 13);
            Assert.AreEqual(numbers.customArray[2], 3);
            Assert.AreEqual(numbers.customArray[11], 2);
        }
        [TestMethod]
        public void OperatorPlusTestIntsOneEmpty()
        {
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            CustomList<int> numbered = new CustomList<int>() {};

            //act
            numbers = numbers + numbered;
            //assert
            Assert.AreEqual(numbers.Count, 10);
            Assert.AreEqual(numbers.customArray[2], 3);
            Assert.AreEqual(numbers.customArray[9], 0);
        }
        [TestMethod]
        public void OperatorPlusTestIntsBothEmpty()
        {
            CustomList<int> numbers = new CustomList<int>() {};
            CustomList<int> numbered = new CustomList<int>() {};

            //act
            numbers = numbers + numbered;
            //assert
            Assert.AreEqual(numbers.Count, 0);
        }
        [TestMethod]
        public void OperatorPlusTestDoubles()
        {
            CustomList<double> numbers = new CustomList<double>() {0, 1.2,.3,100000 };
            CustomList<double> numbered = new CustomList<double>() {4,9,-6,4.9824 };

            //act
            numbers = numbers + numbered;
            //assert
            Assert.AreEqual(numbers.Count, 8);
            Assert.AreEqual(numbers.customArray[3], 100000);
            Assert.AreEqual(numbers.customArray[6], -6);
        }
        [TestMethod]
        public void OperatorMinusTestInts()
        {
            CustomList<int> numbers = new CustomList<int>() {0,1,2,3,4,5};
            CustomList<int> numbered = new CustomList<int>() {3,4,5,6,7};

            //act
            numbers = numbers - numbered;
            //assert
            Assert.AreEqual(numbers.Count, 3);
            Assert.AreEqual(numbers.customArray[0], 0);
            Assert.AreEqual(numbers.customArray[2], 2);
            Assert.AreEqual(numbered.Count, 5);
        }
        [TestMethod]
        public void OperatorMinusTestStrings()
        {
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };
            CustomList<string> wordy = new CustomList<string>() { "cat", "hog", "bark", "bees" };

            //act
            words = words - wordy;
            //assert
            Assert.AreEqual(words.Count, 3);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[2], "bee");
            Assert.AreEqual(wordy.Count, 4);
        }
        [TestMethod]
        public void OperatorMinusTestStringsMultipleSame()
        {
            CustomList<string> words = new CustomList<string>() { "cat","cat", "cat", "dog", "bat", "bee" };
            CustomList<string> wordy = new CustomList<string>() { "cat", "hog", "bark", "bees" };

            //act
            words = words - wordy;
            //assert
            Assert.AreEqual(words.Count, 3);
            Assert.AreEqual(words.customArray[0], "dog");
            Assert.AreEqual(words.customArray[2], "bee");
            Assert.AreEqual(wordy.Count, 4);
        }
        [TestMethod]
        public void OperatorMinusTestStringsNoneSame()
        {
            CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };
            CustomList<string> wordy = new CustomList<string>() { "hog", "bark", "bees" };

            //act
            words = words - wordy;
            //assert
            Assert.AreEqual(words.Count, 4);
            Assert.AreEqual(words.customArray[0], "cat");
            Assert.AreEqual(words.customArray[2], "bat");
            Assert.AreEqual(wordy.Count, 3);
        }
        [TestMethod]
        public void OperatorMinusTestDoubles()
        {
            CustomList<double> numbers = new CustomList<double>() { 0, 1.2, .3, 100000 };
            CustomList<double> numbered = new CustomList<double>() { 1.98, 1, 0, 1, 0, .4444 };

            //act
            numbers = numbers - numbered;
            //assert
            Assert.AreEqual(numbers.Count, 3);
            Assert.AreEqual(numbers.customArray[0], 1.2);
            Assert.AreEqual(numbers.customArray[2], 100000);
            Assert.AreEqual(numbered.Count, 6);
        }
        [TestMethod]
        public void ToStringTestInt()
        {
            CustomList<int> numbers = new CustomList<int>() { 0, 1, 2, 100000 };
            //act
            Console.WriteLine(numbers.ToString());
                {
                }
            //assert
            
        }


        //[TestMethod]
        //public void IterableTestStrings()
        //{
        //    CustomList<string> words = new CustomList<string>() { "cat", "dog", "bat", "bee" };
        //    //act
        //    foreach(string word in words)
        //    {
        //        Console.WriteLine(word);
        //    }
        //    //assert
        //    Assert.IsTrue( )

    }
}