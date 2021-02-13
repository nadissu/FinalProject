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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);

            }
            Console.WriteLine("Hello World!");
        }
    }
}
