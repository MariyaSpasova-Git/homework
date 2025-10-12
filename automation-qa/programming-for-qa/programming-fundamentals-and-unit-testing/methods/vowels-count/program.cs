string text = Console.ReadLine();

int result = PrintVowelsCount(text);
Console.WriteLine(result);

//Console.WriteLine(CountVowels(text));
//static int CountVowels (string text)
//{
//    string vowelSet = "aeiouAEIOU";

//    return text.Count(c => vowelSet.Contains(c));
//}

//teacher's solution
static int PrintVowelsCount (string text)
{
    int counter = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char letter = text[i];

        switch (letter)
        {
            case 'A' or 'O' or 'U' or 'E' or 'I' or 'a' or 'o' or 'u' or 'e' or 'i':
                counter++;
                break;
        }
    }

    return counter;
}