using System;

namespace Kodlamaio_Egitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Id = 1;
            product.ProductName = "Masa";
            product.CategoryId = 2;
            product.UnitPrice = 400;
            product.UnitsInStock = 20;


            Product product1 = new Product
            {
                Id = 2,
                ProductName = "Sandalye",
                CategoryId = 2,
                UnitPrice = 200,
                UnitsInStock = 24,
            };


            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
        }
    }
}
