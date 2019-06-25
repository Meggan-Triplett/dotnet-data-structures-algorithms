using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5 };
            int testValue = 3;
            insertShiftArray(testArray, testValue);
        }

        public static int[] insertShiftArray(int[] inputArray, int value)
        {
            int[] newArray = new int[inputArray.Length + 1];
            int middlePoint = inputArray.Length / 2;

            //Doesn't work for odd number length input array
            //TODO Round middlepoint up to even number 
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i >= middlePoint && i < middlePoint + 1)
                {
                    newArray[i] = value;
                }
                else if (i < middlePoint)
                {
                    newArray[i] = inputArray[i];
                }
                else if (i > middlePoint)
                {
                    newArray[i] = inputArray[i - 1];
                }
            }
            return newArray;
        }
    }
}
