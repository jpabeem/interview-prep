using System;

namespace InterviewPrep.Library
{
    /// <summary>
    /// Description:
    /// 
    /// Rotate an array k times in a given direction (left or right).
    /// 
    /// Example input: array = [1, 4, 9]
    /// Example output: RotateRight(array, 1) => [9, 1, 4]
    /// 
    /// Example input: array = [1, 4, 9]
    /// Example output: RotateLeft(array, 1) => [4, 9, 1]
    /// </summary>
    public class RotateArrayKTimes
    {
        public static int[] RotateRight(int[] inputArray, int kTimes)
        {
            for (int times = 0; times < kTimes; times++)
            {
                inputArray = RotateRight(inputArray);
            }
            return inputArray;
        }

        public static int[] RotateLeft(int[] inputArray, int kTimes)
        {
            for (int times = 0; times < kTimes; times++)
            {
                inputArray = RotateLeft(inputArray);
            }
            return inputArray;
        }

        private static int[] RotateRight(int[] inputArray)
        {
            if (inputArray.Length <= 1)
                return inputArray;

            int lastIndexValue = inputArray[inputArray.Length - 1];

            for (int currentIndex = inputArray.Length - 1; currentIndex >= 0; currentIndex--)
            {
                // Walk from the end of the array to the start while the previous index still exists
                if ((currentIndex - 1) >= 0)
                {
                    inputArray[currentIndex] = inputArray[currentIndex - 1];
                }
                else
                {
                    inputArray[0] = lastIndexValue;
                }
            }

            return inputArray;
        }

        private static int[] RotateLeft(int[] inputArray)
        {
            if (inputArray.Length <= 1)
                return inputArray;

            int valueAtFirstIndex = inputArray[0];
            int lastIndex = inputArray.Length - 1;

            for (int currentIndex = 0; currentIndex < lastIndex; currentIndex++)
            {
                inputArray[currentIndex] = inputArray[currentIndex + 1];
            }

            inputArray[lastIndex] = valueAtFirstIndex;

            return inputArray;
        }
    }
}