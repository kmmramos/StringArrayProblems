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
    }
}
