using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        { 
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tuğçe");
            isimler.Add("Talha");

            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}