//int number = int.Parse(Console.ReadLine());

//PrintMultiplicationOfEvensAndOdds(number);

//static void PrintMultiplicationOfEvensAndOdds (int number)
//{
//    int absoluteNumber = Math.Abs(number);

//    int evenSum = GetSumOfEvenDigits(absoluteNumber);
//    int oddSum = GetSumOfOddDigits(absoluteNumber);

//    int multiplicationOfEvensAndOdds = evenSum * oddSum;

//    Console.WriteLine(multiplicationOfEvensAndOdds);
//}
//static int GetSumOfEvenDigits (int number)
//{
//    int evenDigitsSum = 0;

//    while (number > 0)
//    {
//        int lastDigit = number % 10;

//        if (lastDigit % 2 == 0)
//        {
//        evenDigitsSum += lastDigit;
//        }

//        number /= 10;
//    }

//    return evenDigitsSum;
//}

//static int GetSumOfOddDigits(int number)
//{
//    int oddDigitsSum = 0;

//    while (number > 0)
//    {
//        int lastDigit = number % 10;

//        if (lastDigit % 2 != 0)
//        {
//            oddDigitsSum += lastDigit;
//        }

//        number /= 10;
//    }

//    return oddDigitsSum;
//}

//teacher's solution

namespace _05.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetEvensAndOddsMultiplication(number));
        }

        private static int GetEvensSum (int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetOddsSum (int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetEvensAndOddsMultiplication (int number)
        {
            int result = GetEvensSum(number) * GetOddsSum(number);

            return result;
        }
    }
}