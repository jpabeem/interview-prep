using System;

namespace InterviewPrep.Library
{
    public class StringRotation
    {
        /// <summary>
        /// Description:
        /// 
        /// Check if a given string is a rotation (or substring) of another string.
        /// 
        /// Example input: rotation = "sye", original = "yes"
        /// Example output: IsSubstring(rotation, original) => true
        /// 
        /// Example input: rotation = "tests", original = "test"
        /// Example output: IsSubstring(rotation, original) => false
        /// </summary>
        public static bool IsSubstring(string rotation, string original)
        {
            if (rotation.Length != original.Length)
                return false;

            int sum = 0;

            foreach (var c in original)
            {
                sum ^= c;
            }

            foreach (var c in rotation)
            {
                sum ^= c;
            }

            return sum == 0;
        }
    }
}