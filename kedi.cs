using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class kedi:kopek
    {
        public void sesCikar()
        {
            Console.WriteLine("kedi ses çıkarıyor");
        }

        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("hayvan bilgileri gösteriliyor...");
            Console.WriteLine("hayvan ismi:" + isim);
            Console.WriteLine("hayvan rengi:" + renk);
            Console.WriteLine("hayvan kilo:" + kilo);
            Console.WriteLine("hayvan ayak sayısı:" + ayakSayisi);
            Console.WriteLine("hayvan cinsiyeti:" + cinsiyet);
        }
    }
}
