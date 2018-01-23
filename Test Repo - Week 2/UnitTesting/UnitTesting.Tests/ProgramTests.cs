using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestSumArray()
        {
            // Arrange
            int[] newArray = new int[3] { 1, 2, 3 };
            int expected = 6;

            // Act
            int result = Program.SumArray(newArray);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSumArrayNull()
        {
            // Arrange
            int[] nullArray = null;
            int expected = 0;

            // Act
            int result = Program.SumArray(nullArray);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSumArrayEmpty()
        {
            // Arrange
            int[] emptyArray = new int[0];
            int expected = 0;

            // Act
            int result = Program.SumArray(emptyArray);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetValueAtIndex()
        {
            // Arrange
            int[] newArray = new int[3] { 1, 2, 3 };
            int indexValue = 1;
            int expected = 2;

            // Act
            int result = Program.GetValueAtIndex(newArray, indexValue);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetValueAtIndexNull()
        {
            // Arrange
            int[] nullArray = null;
            int indexValue = -1;
           
            // Act
            Program.GetValueAtIndex(nullArray, indexValue);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetValueAtIndexLow()
        {
            // Arrange
            int[] newArray = new int[3] { 1, 2, 3 };
            int indexValue = -1;

            // Act
            Program.GetValueAtIndex(newArray, indexValue);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetValueAtIndexHigh()
        {
            // Arrange
            int[] newArray = new int[3] { 1, 2, 3 };
            int indexValue = 10;

            // Act
            Program.GetValueAtIndex(newArray, indexValue);
        }

    }
}
