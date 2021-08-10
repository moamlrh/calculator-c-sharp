using System;

namespace Calculator
{
    class App
    {
        readonly static char[] sybmols =  { '-', '+', '/', '*' };
        static void Main(string[] args)
        {
            StartUp();
        }
        static void StartUp()
        {
            Console.WriteLine("____ Calculator with Mo ____");
            int num1 = EnterNumber("First");
            char symbol = EnterSybmol();
            int num2 = EnterNumber("Second");
            int result = GetTheResult(num1, num2, symbol);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The Result is : {result}");
            Console.ResetColor();

            Console.WriteLine(new String('-', 50));
            TryAgain();
        }
        static void TryAgain()
        {
            Console.WriteLine();
            Console.Write("Try Another Calculate [y, n] : ");
            string isYes = Console.ReadLine();
            if (isYes == "y")
            {
                Console.Clear();
                StartUp();
            }
            else if (isYes == "n")
            {
                Exit();
            }
            else
            {
                TryAgain();
            }
        }
        static int EnterNumber(string text)
        {
            try
            {
                int number;
                Console.Write($"Enter You {text} number: ");
                number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter correct number ....");
                return EnterNumber(text);
            }
        }
        static Char EnterSybmol()
        {
            try
            {
                char sybmol;
                Console.Write($"chose => [+, -, /, *] : ");
                sybmol = Convert.ToChar(Console.ReadLine());
                while (Array.IndexOf(sybmols, sybmol) <= -1)
                {
                    return EnterSybmol();
                }
                return sybmol;
            }
            catch (Exception)
            {
                Console.WriteLine("Try again....");
                return EnterSybmol();
            }
        }

        static int GetTheResult(int num1, int num2, char symbol)
        {
            int result;
            switch (symbol)
            {
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
            
        static void Exit()
        {
            Environment.Exit(0);
        }
    
    }
}
