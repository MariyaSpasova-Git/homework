double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

//string productSign;

//if (firstNumber == 0
//    || secondNumber == 0
//    || thirdNumber == 0)
//{
//    productSign = "zero";
//}

//else if (firstNumber > 0)
//{
//    if (secondNumber > 0)
//    {
//        if (thirdNumber > 0)
//        {
//            productSign = "positive";
//        }
//        else
//        {
//            productSign = "negative";
//        }
//    }
//    else
//    {
//        if (thirdNumber > 0)
//        {
//            productSign = "negative";
//        }
//        else
//        {
//            productSign = "positive";
//        }
//    }
//}
//else
//{
//    if (secondNumber > 0)
//    {
//        if (thirdNumber > 0)
//        {
//            productSign = "negative";
//        }
//        else
//        {
//            productSign = "positive";
//        }
//    }
//    else
//    {
//        if (thirdNumber > 0)
//        {
//            productSign = "positive";
//        }
//        else
//        {
//            productSign = "negative";
//        }
//    }
//}
//
//Console.WriteLine(productSign);

int numberOfNegativeSigns = 0;
string productSign = "";

if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    productSign = "zero";
}
else
{
    if (firstNumber < 0)
    {
        numberOfNegativeSigns++;
    }
    if (secondNumber < 0)
    {
        numberOfNegativeSigns++;
    }
    if (thirdNumber < 0)
    {
        numberOfNegativeSigns++;
    }
}

if (productSign != "zero" && numberOfNegativeSigns % 2 == 0)
{
    productSign = "positive";
}
else
{
    productSign = "negative";
}

Console.WriteLine(productSign);
