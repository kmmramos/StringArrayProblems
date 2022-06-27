using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayProblems.Logic
{
    public class ProblemFour
    {
        public static bool IsAlmostPalindrome(char[] S)
        {
            int left = 0, right = S.Length - 1;
            while (left <= right)
            {
                if (S[left] != S[right])
                {
                    return IsPalindrome(S, left + 1, right) || IsPalindrome(S, left, right - 1);
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool IsPalindrome(char[] S, int left, int right)
        {
            while (left < right)
            {
                if (S[left] != S[right])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
