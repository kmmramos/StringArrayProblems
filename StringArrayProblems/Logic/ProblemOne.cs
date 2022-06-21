namespace StringArrayProblems.Logic
{
    public static class ProblemOne
    {
        ////BRUTE FORCE SOLUTION
        //public static bool CompareString(char[] S, char[] T)
        //{
        //    //call another method for each array
        //    char[] sFinal = BackSpace(S);
        //    char[] tFinal = BackSpace(T);
        //    if (sFinal.Length != tFinal.Length)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < sFinal.Length; i++)
        //        {
        //            if (sFinal[i] != tFinal[i])
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //private static char[] BackSpace(char[] Array)
        //{
        //    Stack<char> st = new Stack<char>();
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        if (Array[i] != '#')
        //        {
        //            st.Push(Array[i]);
        //        }
        //        else
        //        {
        //            st.Pop();
        //        }
        //    }
        //    char[] result = st.ToArray();
        //    return result;
        //}

        //OPTIMIZED SOLUTION
        public static bool CompareString(char[] S, char[] T)
        {
            int P1 = S.Length-1, P2 = T.Length-1;
            while (P1 >= 0 || P2 >= 0)
            {
                if (S[P1] == '#' || T[P2] == '#')
                {
                    if (S[P1] == '#')
                    {
                        int backCount = 2;
                        while (backCount > 0)
                        {
                            P1--;
                            backCount--;
                            if (S[P1] == '#')
                            {
                                backCount = backCount + 2;
                            }
                        }
                    }

                    if (T[P2] == '#')
                    {
                        int backCount = 2;
                        while (backCount > 0)
                        {
                            P2--;
                            backCount--;
                            if (T[P2] == '#')
                            {
                                backCount = backCount + 2;
                            }
                        }
                    }
                }
                else
                {
                    if (S[P1] != T[P2])
                    {
                        return false;
                    }
                    else
                    {
                        P1--;
                        P2--;
                    }
                }
            }
            return true;
        }
    }
}
