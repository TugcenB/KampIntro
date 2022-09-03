using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); 
            product1.Name="Okul Çantası";
            product1.Description="Flamingo Desenli";
            product1.Price=149.90;

            Product product2 = new Product();
            product2.Name="Defter";
            product2.Description="Neon Kapaklı A4 Yaprak 4'lü";
            product2.Price=59.90;

            Product product3 = new Product();
            product3.Name=("Baharatlık");
            product3.Description=("Etiketli 12 Adet Kapağı Kendinden Kaşıklıklı");
            product3.Price=(99.90);

            List<Product> products = new List<Product>() { product1, product2, product3};
            //Oluşturulan ürünleri listeledik.

            
            
            foreach (var product in products)
            {
                Console.WriteLine(product.Description+" "+product.Name+" : "+product.Price+"TL");
            }
            Console.WriteLine("---------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(products[i].Name);
            }
            Console.WriteLine("---------------------");

            int a = 0;
            while (a < products.Count)//a değeri products' ın totalinden küçük olduğu sürece döngüye girer.
            {
                Console.WriteLine(products[a].Description + " " + products[a].Name + " : " + products[a].Price + "TL");
                a++;// Her döngüden sonra a değerini bir arttırır.
            }
            //Ref-Out
            int x = 5;
            int y;
            RefNumber(ref x);
            OutNumber(out y);

            //params
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6));

           
        }

        static void RefNumber(ref int x)
        {
            Console.WriteLine(x);
        }
        static void OutNumber(out int y)
        {
            y = 10;
            Console.WriteLine(y);
        }
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}