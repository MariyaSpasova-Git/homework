int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

//PrintFactorialDivision(firstNumber, secondNumber);

//static void PrintFactorialDivision (int firstNumber, int secondNumber)
//{
//    int firstNumberFactorial = CalculateFactorial(firstNumber);
//    int secondNumberFactorial = CalculateFactorial(secondNumber);

//    int factorialDivision = firstNumberFactorial / secondNumberFactorial;

//    Console.WriteLine(factorialDivision);
//}

//static int CalculateFactorial (int number)
//{
//    int factorialResult = 1;

//    for (int currentNumber = number; currentNumber >= 1; currentNumber--)
//    {
//        factorialResult *= currentNumber;
//    }

//    return factorialResult;
//}

// teacher's solution

int firstFactorial = FindFactorial(firstNumber);
int secondFactorial = FindFactorial(secondNumber);

int result = firstFactorial / secondFactorial;

Console.WriteLine(result);

static int FindFactorial(int x)
{
    int factorial = 1;

    for (int i = 1; i <= x; i++)
    {
        factorial *= i;
    }

    return factorial;
}