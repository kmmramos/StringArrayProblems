using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayProblems.Logic
{
    public class ProblemThree
    {
        public static bool IsPalindrome_Using2PointerFromOutside(char[] S)
        {
            int left = 0, right = S.Length - 1;
            while (left < right)
            {
                if (S[left] != S[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static bool IsPalindrome_UsingCompareAgainstReverse(char[] S)
        {
            return S.SequenceEqual(S.Reverse());
        }

        public static bool IsPalindrome_Using2PointerFromCenter(char[] S)
        {
            int left = (S.Length) / 2;
            int right = left;
            if ((S.Length) % 2 == 0)
            {
                left--;
            }
            while (left >= 0)
            {
                if (S[left] != S[right])
                {
                    return false;
                }
                left--;
                right++;
            }
            return true;
        }
    }
}
