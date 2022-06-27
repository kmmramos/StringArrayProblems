using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayProblems.Logic
{
    public static class ProblemTwo
    {
        //BRUTE FORCE
        //public static int LongestSubstring(char[] S)
        //{
        //    if (S.Length <= 1)
        //        return S.Length;

        //    int longest = 0;
        //    for (int left = 0; left < S.Length; left++)
        //    {
        //        Dictionary<char, int> seenChars = new Dictionary<char, int>();
        //        int currentLength = 0;
        //        for (int right = left; right < S.Length; right++)
        //        {
        //            int currentChar = S[right];
        //            if (!seenChars.ContainsKey(S[right]))
        //            {
        //                currentLength++;
        //                seenChars[S[right]] = currentChar;
        //                longest = Math.Max(longest, currentLength);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    return longest;
        //}

        //OPTIMAL SOLUTION
        public static int LongestSubstring(char[] S)
        {
            // Creating a set to store the last positions of occurrence
            Dictionary<char, int> seen = new Dictionary<char, int>();
            int maximum_length = 0;

            // starting the initial point of window to index 0
            int start = 0;

            for (int end = 0; end < S.Length; end++)
            {
                // Checking if we have already seen the element or not
                if (seen.ContainsKey(S[end]))
                {
                    // If we have seen the number, move the start pointer
                    // to position after the last occurrence
                    start = Math.Max(start, seen[S[end]] + 1);
                }

                // Updating the last seen value of the character
                seen[S[end]] = end;
                maximum_length = Math.Max(maximum_length, end - start + 1);
            }
            return maximum_length;
        }
    }
}
