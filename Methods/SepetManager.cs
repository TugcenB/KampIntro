using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! " +urun.Adi+ " sepete eklendi.");
        }

        public void Ekle2(string adi, double fiyat, string aciklama, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! " + adi + " sepete eklendi.");
        }
    }
}
