using System;
using System.Text;

namespace InterviewPrep.Library
{
    /// <summary>
    /// Description:
    /// 
    /// Compress a string using the counts of repeated characters. If the length of the compressed string
    /// is not smaller than the original string, return the original string.
    /// 
    /// Example input:  input = "aabbbccc"
    /// Example output: Compress(input) => a2b3c3
    /// </summary>
    public class StringCompression
    {
        public static string Compress(string input)
        {
            var stringBuilder = new StringBuilder();
            
            for (int loopCount = 0; loopCount < input.Length; loopCount++)
            {
                char currentChar = input[loopCount];
                int sameCharCounter = 1;
                bool lookingAhead = true;

                while (lookingAhead)
                {
                    int nextIndex = loopCount + 1;
                    if (nextIndex <= input.Length - 1)
                    {
                        char nextIndexChar = input[nextIndex];
                        if (nextIndexChar == currentChar)
                        {
                            sameCharCounter++;
                            loopCount++;
                            continue;
                        }
                    }
                    break;
                }

                stringBuilder.Append($"{currentChar}{sameCharCounter}");
            }

            string output = stringBuilder.ToString();

            return output.Length < input.Length ? output : input;
        }
    }
}