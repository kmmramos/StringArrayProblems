using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayProblems.Logic
{
    public class ProblemSix
    {
        public static int NextGreater(int N)
        {
            string nextNumberString = (N + 1).ToString();
            Stack<int> temporaryStack = new Stack<int>();
            //loop through number string
            int i = 0;
            for (; i < nextNumberString.Length; i++)
            {
                var currentDigit = nextNumberString[i];
                if (temporaryStack.Count == 0 || temporaryStack.Peek() != (currentDigit - '0')) //if stack is empty or if previous != current digit
                {
                    temporaryStack.Push(currentDigit - '0'); //continue pushing the current digit to the temporaryStack
                }
                else if (temporaryStack.Peek() == 9) //handle the edge case which is the number containing digit 9
                {
                    temporaryStack.Pop(); //remove current digit which is 9

                    if (temporaryStack.Count == 0) //if stack is now empty
                    {
                        //recreate temporaryStack
                        temporaryStack.Push(1);
                        temporaryStack.Push(0);
                        temporaryStack.Push(1);
                    }
                    else
                    {
                        //continue by pushing the previous digit to the stack plus 1
                        var top = temporaryStack.Pop();
                        temporaryStack.Push(top + 1);
                        temporaryStack.Push(0);
                        temporaryStack.Push(1);
                    }
                    break;
                }
                else
                {
                    //last value from temporaryStack equals the current digit
                    temporaryStack.Push((currentDigit - '0') + 1);
                    break;
                }
            }
            //continue pushing to temporary stack if there are remaining digits which we haven't checked yet
            i++;
            int insert = 0;
            while (i < nextNumberString.Length)
            {
                temporaryStack.Push(insert);
                if (insert == 0)
                {
                    insert = 1;
                }
                else
                {
                    insert = 0;
                }
                i++;
            }
            //since stack IS LIFO, we need to reverse its order
            int finalResult = 0;
            var arr = temporaryStack.ToArray().Reverse();
            foreach (var a in arr)
            {
                finalResult = finalResult * 10 + a;
            }
            //check if the final result has repeating consecutive digit
            string finalResultString = finalResult.ToString();
            for (int j = 0; j < finalResultString.Length - 1; j++)
            {
                //once this condition is satisfied, it means we need to perform finding NextGreater int again
                if (finalResultString[j] == finalResultString[j + 1])
                {
                    //perform recursion, execute the method again to find the next greater number
                    return NextGreater(finalResult);
                }
            }
            //return final result
            return finalResult;
        }

    }
}
