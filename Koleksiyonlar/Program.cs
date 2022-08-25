using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("----------------");

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("İlker");
            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }




        }
    }
}