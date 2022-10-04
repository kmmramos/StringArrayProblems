using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayProblems.Logic
{
    public class ProblemFive
    {
        public static int CoinStackExchange(int[] A)
        {
            int arrayLength = A.Length;
            int quotient = 0, dividend, remainder, lastRemainder = 0, partialTotal = 0;
            //return the 1 or 0, if that's the only value
            if (arrayLength <= 1 && A[0] <= 1) return A[0];
            //return 0 if null
            else if (A == null) return 0;
            //loop inside array or if the only element is greater than 1
            else
            {
                //set the only element to be processed if greater than 1
                if (arrayLength <= 1 && A[0] > 1) quotient = A[0];
                //loop inside an array or continue execution as long as the value/quotient is greater than 1
                int index = 0;
                while (index < arrayLength || quotient >= 2)
                {
                    if (arrayLength >= 2 && index < arrayLength)
                    {
                        quotient = quotient + A[index];
                    }
                    //coin stack exchange operation, the main logic
                    dividend = quotient;
                    quotient = dividend / 2;
                    remainder = dividend % 2;
                    partialTotal += remainder;
                    index++;
                }
                //if there's a last remaining value or quotient that's less than 2, add it as the lastRemainder
                if (quotient <= 1) lastRemainder = quotient;

                //compute for the total got from lastremainder (if there's value) plus the computer partialTotal
                int total = lastRemainder + partialTotal;
                return total;
            }
        }
    }
}
