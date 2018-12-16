using System;

namespace InterviewPrep.Library
{
    /// <summary>
    /// Description:
    /// 
    /// Find the unique number in an array with duplicate numbers.
    /// 
    /// Example input: array = [1, 1, 2, 2, 4, 4, 9]
    /// Example output: FindUnique(array) => 9
    /// </summary>
    public class SingleNumber
    {
        public static int FindUnique(int[] inputArray)
        {
            int uniqueSum = 0;
            foreach (int number in inputArray)
            {
                uniqueSum ^= number;
            }

            return uniqueSum;
        }
    }
}