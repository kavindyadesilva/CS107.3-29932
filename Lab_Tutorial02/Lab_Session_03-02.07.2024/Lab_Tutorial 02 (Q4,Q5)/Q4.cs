using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_02__Q4_
{
     class Product
    {
        public string ProductName;
        public double Price;

        public Product(string productName,double price)
        {
            ProductName = productName;
            Price = price;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("laptop", 200000);
            Product product2 = new Product("smartphone", 50000);

            Console.WriteLine(product1);
            Console.WriteLine("Name:" + product1.ProductName);
            Console.WriteLine("Price:$" + product1.Price);
            Console.WriteLine();

            Console.WriteLine(product2);
            Console.WriteLine("Name:" + product2.ProductName);
            Console.WriteLine("Price:$" + product2.Price);
            Console.ReadLine();
        }
    }
        
}
