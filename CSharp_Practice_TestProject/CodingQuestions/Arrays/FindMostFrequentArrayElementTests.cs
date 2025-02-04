using CSharp_Practice.CodingQuestions.Arrays;

namespace CSharp_Practice_TestProject.CodingQuestions.Arrays
{
    [TestClass]
    public class FindMostFrequentArrayElementTests
    {
        [TestMethod]
        public void TestMostFrequentElement_WithMultipleOccurrences()
        {
            //Arrange
            int[] arr = new int[] { 1, 5, 2, 4, 6, 1 };

            //Act
            int result = FindMostFrequentArrayElement.MostFrequentElement(arr);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMostFrequentElement_WithSingleOccurrence()
        {
            //Arrange
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            //Act
            int result = FindMostFrequentArrayElement.MostFrequentElement(arr);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMostFrequentElement_WithAllSameElements()
        {
            //Arrange
            int[] arr = new int[] { 7, 7, 7, 7, 7 };

            //Act
            int result = FindMostFrequentArrayElement.MostFrequentElement(arr);

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMostFrequentElement_WithNegativeNumbers()
        {
            //Arrange
            int[] arr = new int[] { -1, -1, -2, -3, -2, -1 };

            //Act
            int result = FindMostFrequentArrayElement.MostFrequentElement(arr);

            //Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMostFrequentElement_WithEmptyArray()
        {
            //Arrange
            int[] arr = new int[] { };

            //Act
            int result = FindMostFrequentArrayElement.MostFrequentElement(arr);

            //Assert
            Assert.AreEqual(-1, result);
        }

    }
}