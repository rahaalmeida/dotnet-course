using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioPolimorfismo.Entities;

namespace ExercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c/u/i)?");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(productType == 'i' || productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(nameProduct, price, customFee));
                }
                else if(productType == 'u' || productType == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(nameProduct, price, dateManufacture));
                }
                else
                {
                    product.Add(new Product(nameProduct, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            }

            Console.ReadLine();
        }
    }
}
