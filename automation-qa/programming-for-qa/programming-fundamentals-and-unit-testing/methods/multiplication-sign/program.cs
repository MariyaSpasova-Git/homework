//int firstNumber = int.Parse(Console.ReadLine());
//int secondNumber = int.Parse(Console.ReadLine());
//int thirdNumber = int.Parse(Console.ReadLine());

//PrintMultiplicationSign(firstNumber, secondNumber, thirdNumber);

//static void PrintMultiplicationSign (int firstNumber, int secondNumber, int thirdNumber)
//{
//    string result = "";

//    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
//    {
//        Console.WriteLine("zero");
//        return;
//    }

//    int negativeSignCounter = 0;

//    if (firstNumber < 0)
//    {
//        negativeSignCounter++;
//    }

//    if (secondNumber < 0)
//    {
//        negativeSignCounter++;
//    }

//    if (thirdNumber < 0)
//    {
//       negativeSignCounter++;
//    }

//    if (negativeSignCounter % 2 == 0)
//    {
//        Console.WriteLine("positive");
//    }
//    else
//    {
//        Console.WriteLine("negative");
//    }
//}

// teacher's solution

namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            string result = PrintProductSign (number1, number2, number3);

            Console.WriteLine(result);
        }

        static string PrintProductSign (int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                return "zero";
            }
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                return "positive";
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                return "negative";
            }
            else if (firstNumber < 0)
            {
                if (secondNumber < 0 && thirdNumber > 0)
                {
                    return "positive";
                }
                else if (secondNumber > 0 && thirdNumber < 0)
                {
                    return "positive";
                }
                else
                {
                    return "negative";
                }
            }
            else if (secondNumber < 0 && thirdNumber < 0)
            {
                return "positive";
            }
            else if (secondNumber < 0 && thirdNumber > 0)
            {
                return "negative";
            }
            else
            {
                return "negative";
            }

        }
    }
}