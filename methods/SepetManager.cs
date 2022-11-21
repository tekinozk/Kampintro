using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
     class SepetManager
    {
        public void Ekle(product urun)
            
        {
            Console.WriteLine("Sepete Eklendi : "  + urun.Adi + "," + urun.Stokadedi);
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)

        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi + "-" + stokadedi);
        }

    }
}
