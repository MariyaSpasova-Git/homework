namespace multiplication-sign
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