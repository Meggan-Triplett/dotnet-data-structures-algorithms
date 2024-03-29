using System;
using Xunit;
using InsertionSort.Classes;

namespace InsertionSortUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertionSortWithInputIntArrayWithOneInt()
        {
            int[] testArray = new int[1] { 42 };
            int[] expectedArray = new int[1] { 42 };
            int[] actualArray = InsertionSortMethods.InsertionSort(testArray);

            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void CanInsertionSortWithInputIntArrayWithEvenNumberOfInts()
        {
            int[] testArray = new int[4] { 67, 4, 42, 9 };
            int[] expectedArray = new int[4] { 4, 9, 42, 67 };
            int[] actualArray = InsertionSortMethods.InsertionSort(testArray);

            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void CanInsertionSortWithInputIntArrayWithOddNumberOfInts()
        {
            int[] testArray = new int[7] { 67, 4, 42, 9, 21, 91, 15 };
            int[] expectedArray = new int[7] { 4, 9, 15, 21, 42, 67, 91 };
            int[] actualArray = InsertionSortMethods.InsertionSort(testArray);

            Assert.Equal(expectedArray, actualArray);
        }
    }
}
