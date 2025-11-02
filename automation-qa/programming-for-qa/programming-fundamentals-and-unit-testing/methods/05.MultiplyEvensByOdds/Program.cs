namespace multiply-evens-by-odds
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