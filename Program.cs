using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class Program
    {
        static void Main(string[] args)
        {
            kedi kedi1= new kedi();
            kedi1.kilo = 12;
            kedi1.renk = "siyah";
            kedi1.ayakSayisi = 4;
            kedi1.cinsiyet = "dişi";
            kedi1.isim = "minnoş";
            kedi1.hayvanBilgileriGoster();
            kedi1.sesCikar();
            Console.ReadLine();
        }
    }
}
