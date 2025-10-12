//string product = Console.ReadLine();
//int quantity = int.Parse(Console.ReadLine());

//PrintOrderPrice(product, quantity);

//static void PrintOrderPrice (string product, int quantity)
//{
//    double totalPrice = GetProductUnitPrice(product) * quantity;
//    Console.WriteLine($"{totalPrice:F2}");
//}

//static double GetProductUnitPrice(string product)
//{
//    double productUnitPrice = product switch
//    {
//       "coffee" => 1.50,
//       "water" => 1.00,
//       "coke" => 1.40,
//       "snacks" => 2.00,
//       _ => 0.00
//    };

//    return productUnitPrice;
//}

// teacher's solution

namespace _06.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOrderPrice(product, quantity);
        }

        static void PrintOrderPrice(string product, int quantity)
        {
            double productPrice = 0;

            switch (product)
            {
                case "coffee": productPrice = 1.50; break;
                case "water": productPrice = 1.00; break;
                case "coke": productPrice = 1.40; break;
                case "snacks": productPrice = 2.00; break;
            }

            double finalPrice = productPrice * quantity;

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}