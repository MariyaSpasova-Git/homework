string product = Console.ReadLine();

string productType;

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
        productType = "fruit";
        break;
    case "cucumber":
    case "pepper":
    case "carrot":
        productType = "vegetable";
        break;
    default:
        productType = "unknown";
        break;
}

Console.WriteLine(productType);
