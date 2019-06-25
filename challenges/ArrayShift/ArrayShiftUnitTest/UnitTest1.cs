using System;
using Xunit;
using ArrayShift;

namespace ArrayShiftUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertShiftArrayCanInsertValueIntoMiddleOfEvenSizeArray()
        {
            int[] testArray = { 1, 2, 4, 5 };
            int testValue = 3;
            string expectedString = "1 2 3 4 5";

            int[] actualArray = Program.insertShiftArray(testArray, testValue);
            string actualString = string.Join(" ", actualArray);

            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void InsertShiftArrayCanInsertValueIntoMiddleOfOddSizeArray()
        {
            int[] testArray = { 1, 2, 4, 5, 6 };
            int testValue = 3;
            string expectedString = "1 2 4 3 5 6";

            int[] actualArray = Program.insertShiftArray(testArray, testValue);
            string actualString = string.Join(" ", actualArray);

            Assert.Equal(expectedString, actualString);
        }
    }
}
