using System;

namespace EntityFrameworkDemo
{
    class Program
{
    private static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework - Bir ORM Object Relational Mapping
            //NHibernate
            //Dapper
            //GetAll();
            GetByCategoryId(2);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var item in context.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        private static void GetByCategoryId(int id)
        {
            NorthwindContext context = new NorthwindContext();

            var result = context.Products.Where(p=>p.CategoryId==id);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}