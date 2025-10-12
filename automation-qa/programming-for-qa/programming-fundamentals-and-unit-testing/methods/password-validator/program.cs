namespace password-validator
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