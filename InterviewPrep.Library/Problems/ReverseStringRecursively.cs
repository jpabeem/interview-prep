using System;

namespace InterviewPrep.Library
{
    /// <summary>
    /// Description:
    /// 
    /// Reverse a string recursively.
    /// 
    /// Example input: string = "lepel"
    /// Example output: Reverse("lepel") => "lepel"
    /// </summary>
    public class ReverseStringRecursively
    {
        public static string Reverse(string input)
        {
            if (input == "")
                return "";

            var substr = input.Substring(0, input.Length - 1);
            var lastChar = input[input.Length - 1];

            return lastChar + Reverse(substr);
        }
    }
}