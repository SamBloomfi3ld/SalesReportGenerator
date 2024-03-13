

using System.Numerics;

namespace SalesReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to store.\n" + "In my store we sell various things as listed below:\n");
            string[] product = { "Clothes", "shoes", "Food", "Drinks" };
            double[] price = { 60, 80, 80, 40 };
            int[] sales = { 180, 50, 620, 280 };

            int totalsales = 0;

            Console.WriteLine("Sales Report");

            double totalSales = 0;

            for (int i = 0; i < product.Length; i++)
            {
                double productTotalSales = sales[i] * price[i];

                totalSales += productTotalSales;

                Console.WriteLine($"Product: {product[i]}");
                Console.WriteLine($"Sales: {sales[i]}");
                Console.WriteLine($"Price per Unit: ${price[i]}");
                Console.WriteLine($"Total Sales: ${productTotalSales}");
                Console.WriteLine("\n");
               
            }

            Console.WriteLine($"Total Sales for All Products: ${totalSales}");

        }    
    }
}