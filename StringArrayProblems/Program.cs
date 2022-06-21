using StringArrayProblems.Common;

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
                //Console.WriteLine("[4] Exit");
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
                bool isExit = false;
                switch (choice)
                {
                    case 1:
                        Display.Problem1();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        isExit = true;
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}