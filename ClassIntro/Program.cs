using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.KursAdi = "C#";
            kurs.Egitmen = "Engin Demiroğ";
            kurs.izlenmeOrani = 68;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.izlenmeOrani = 80;

            Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen);
            
            Kurs[] kurslar = new Kurs[] { kurs, kurs1,kurs3 };
            foreach (var a in kurslar)
            {
                Console.WriteLine(a.KursAdi+" : "+a.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}