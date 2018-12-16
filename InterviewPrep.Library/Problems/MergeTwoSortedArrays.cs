using System;

namespace InterviewPrep.Library
{
    /// <summary>
    /// Description:
    /// 
    /// Merge two (given) sorted arrays together, return the result.
    /// 
    /// Example input: array1 = [1, 4, 9], array2 = [2, 7, 11]
    /// Example output: Merge(array1, array2) => [1, 2, 4, 7, 9, 11]
    /// </summary>
    public class MergeTwoSortedArrays
    {
        public static int[] Merge(int[] array1, int[] array2)
        {
            int totalLength = array1.Length + array2.Length, currentIndex = 0, 
                currentIndexArray1 = 0, currentIndexArray2 = 0;

            int[] result = new int[totalLength];

            while (currentIndex < totalLength)
            {
                if (currentIndexArray1 == array1.Length)
                {
                    result[currentIndex] = array2[currentIndexArray2];
                    break;
                }

                if (currentIndexArray2 == array2.Length)
                {
                    result[currentIndex] = array1[currentIndexArray1];
                    break;
                }

                if (array2[currentIndexArray2] < array1[currentIndexArray1])
                {
                    result[currentIndex] = array2[currentIndexArray2];
                    currentIndex++; currentIndexArray2++;
                }
                else
                {
                    result[currentIndex] = array1[currentIndexArray1];
                    currentIndex++; currentIndexArray1++;
                }
            }

            return result;
        }
    }
}