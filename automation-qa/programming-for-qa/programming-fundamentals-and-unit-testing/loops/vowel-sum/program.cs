int aValue = 1;
int eValue = 2;
int iValue = 3;
int oValue = 4;
int uValue = 5;

int count = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= count; i++)
{
    char vowel = char.Parse(Console.ReadLine());

    switch (vowel)
    {
        case 'a':
            sum += aValue;
            break;
        case 'e':
            sum += eValue;
            break;
        case 'i':
            sum += iValue;
            break;
        case 'o':
            sum += oValue;
            break;
        case 'u':
            sum += uValue;
            break;
        default:
            break;
    }
}

Console.WriteLine(sum);

