//string password = Console.ReadLine();

//ValidatePassword(password);

//static void ValidatePassword (string password)
//{
//    string firstValidationResult = ValidateCharCountMatch(password);
//    string secondValidationResult = ValidateCorrectCharType(password);
//    string thirdValidationResult = ValidateMinimumDigitsCount(password);

//    bool isValid = true;

//    if (firstValidationResult != null)
//    {
//        Console.WriteLine(firstValidationResult);
//        isValid = false;
//    }

//    if (secondValidationResult! != null)
//    {
//        Console.WriteLine(secondValidationResult);
//        isValid = false;
//    }

//    if (thirdValidationResult! != null)
//    {
//        Console.WriteLine(thirdValidationResult);
//        isValid = false;
//    }

//    if (isValid)
//    {
//        Console.WriteLine("Password is valid");
//    }
//}
//static string ValidateCharCountMatch (string password)
//{
//    int charCount = password.Length;

//    if (charCount < 6 || charCount > 10)
//    {
//        return "Password must be between 6 and 10 characters";
//    }

//    return null;
//}

//static string ValidateCorrectCharType (string password)
//{
//    if (!password.All(char.IsLetterOrDigit))
//    {
//        return "Password must consist only of letters and digits";
//    }
    
//    return null;
//}

//static string ValidateMinimumDigitsCount (string password)
//{
//    if (password.Count(char.IsDigit) < 2)
//    {
//        return "Password must have at least 2 digits";
//    }

//    return null;
//}

//teacher's solution

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CheckPasswordLength(password) &&
                CheckPasswordCharactersType(password) &&
                CheckPasswordMinimumDigitsCount(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!CheckPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckPasswordCharactersType(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckPasswordMinimumDigitsCount(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool CheckPasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool CheckPasswordCharactersType(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentCharacter = password[i];

                if (!char.IsLetter(currentCharacter) && !char.IsDigit(currentCharacter))
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckPasswordMinimumDigitsCount(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];

                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }

            return false;
        }
    }
}