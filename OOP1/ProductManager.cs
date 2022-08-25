using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName+" sepetinize eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //public void BiSeyYap(int sayi){sayi = 99;}

    }
}
