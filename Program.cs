using System;

namespace Second_Digit_Number
{
    public class Answer
    {
        static void PrintSecondDigit(int number)
        {
            string numStr = number.ToString();
            char num = numStr[1];
            Console.WriteLine(num);            
        }

        static public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите трехзначное число");
            int number;

            if (args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            PrintSecondDigit(number);
        }
    }
}


