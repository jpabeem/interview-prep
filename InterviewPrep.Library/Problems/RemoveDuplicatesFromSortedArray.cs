using System;
using System.Collections.Generic;

namespace InterviewPrep.Library
{
    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// Description:
        /// 
        /// Remove the duplicates from a sorted array
        /// and return the length of the new array without duplicates.
        /// 
        /// Example input: array = [1, 1, 2, 2, 4, 4, 9]
        /// Example output: GetLengthWithoutDuplicates(array) => 4
        /// </summary>
        public static int GetLengthWithoutDuplicates(int[] sortedArray)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            int arrayLengthWithoutDuplicates = 0;

            foreach (var number in sortedArray)
            {
                if (!dict.ContainsKey(number))
                {
                    arrayLengthWithoutDuplicates++;
                    dict[number] = true;
                }
            }

            return arrayLengthWithoutDuplicates;
        }
    }
}