using StringArrayProblems.Logic;

namespace StringArrayProblems.Common
{
    public static class Display
    {
        public static void Problem1()
        {
            Console.Write("Please enter the first string: ");
            string sString = Console.ReadLine();
            char[] S = new char[sString.Length];
            for (int i = 0; i < sString.Length; i++)
            {
                S[i] = sString[i];
            }

            Console.Write("Please enter the second string: ");
            string tString = Console.ReadLine();
            char[] T = new char[tString.Length];
            for (int i = 0; i < tString.Length; i++)
            {
                T[i] = tString[i];
            }

            if (ProblemOne.CompareString(S, T))
            {
                Console.WriteLine("YES, they are equal strings!");
            }
            else
            {
                Console.WriteLine("NO, they are not equal strings!");
            }
        }

        public static void Problem2()
        {
            Console.Write("Please enter the string: ");
            string sString = Console.ReadLine();
            char[] S = new char[sString.Length];
            for (int i = 0; i < sString.Length; i++)
            {
                S[i] = sString[i];
            }

            Console.Write("The longest length of substring is: " + ProblemTwo.LongestSubstring(S));
        }

        public static void Problem3()
        {
            Console.Write("Please enter the string: ");
            string sString = Console.ReadLine();
            char[] S = new char[sString.Length];
            for (int i = 0; i < sString.Length; i++)
            {
                S[i] = sString[i];
            }

            Console.WriteLine("Choose a solution:");
            Console.WriteLine("[1] 2-pointers from outside");
            Console.WriteLine("[2] compare against reverse");
            Console.WriteLine("[3] 2-pointer from center");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool isPalindrome = false;
            try
            {                
                switch (choice)
                {
                    case 1:
                        isPalindrome = ProblemThree.IsPalindrome_Using2PointerFromOutside(S);
                        break;
                    case 2:
                        isPalindrome = ProblemThree.IsPalindrome_UsingCompareAgainstReverse(S);
                        break;
                    case 3:
                        isPalindrome = ProblemThree.IsPalindrome_Using2PointerFromCenter(S);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("The string is" + (isPalindrome? " a " : " not a ") + "Palindrome.");
        }

        public static void Problem4()
        {
            Console.Write("Please enter the string: ");
            string sString = Console.ReadLine();
            char[] S = new char[sString.Length];
            for (int i = 0; i < sString.Length; i++)
            {
                S[i] = sString[i];
            }
            Console.Write("The string is" + (ProblemFour.IsAlmostPalindrome(S) ? " an " : " not an ") + "almost Palindrome.");
        }
    }
}
