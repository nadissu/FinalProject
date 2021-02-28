using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
    //SOLID
{
    class Program
    {
        //Open Closed pienciple yaptığın yazıım ayeni bir özellik ekliyorsan mevcuttaki hiç bir koduna dokunamazsın
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

                }
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

