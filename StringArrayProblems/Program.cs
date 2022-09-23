﻿using StringArrayProblems.Common;

namespace StringArrayProblems
{
    class Program
    {
        public static int SelectAction()
        {
            int choice = -1;
            string input = string.Empty;
            do
            {
                Console.WriteLine("Actions");
                Console.WriteLine("Select only from 1 to 5.");
                Console.WriteLine("[1] Backspace String Problem");
                Console.WriteLine("[2] Longest Substring Problem");
                Console.WriteLine("[3] Palindrom Problem");
                Console.WriteLine("[4] Almost Palindrom Problem");
                Console.WriteLine("[5] Stack Coin Exchange");
                Console.WriteLine("[6] Smallest integer with no consecutive same digits");
                Console.WriteLine("Enter action:");
                input = Console.ReadLine();
                choice = Validator.IsInteger(ref input, choice);
                Console.Clear();
            } while (string.IsNullOrEmpty(input));
            return choice;
        }

        static void Main(String[] args)
        {
            try
            {
                int choice = SelectAction();
                switch (choice)
                {
                    case 1:
                        Display.Problem1();
                        break;
                    case 2:
                        Display.Problem2();
                        break;
                    case 3:
                        Display.Problem3();
                        break;
                    case 4:
                        Display.Problem4();
                        break;
                    case 5:
                        Display.Problem5();
                        break;
                    case 6:
                        Display.Problem6();
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}