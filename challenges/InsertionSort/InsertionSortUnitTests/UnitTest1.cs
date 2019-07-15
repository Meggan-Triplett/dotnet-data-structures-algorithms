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
    }
}
