using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_2_sayıyı_bölen_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bolunen, bolen, bolum;

            Console.WriteLine("Lütfen Bölünen Sayıyı Giriniz");
            bolunen = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Bölen Sayıyı Giriniz");
            bolen = Int32.Parse(Console.ReadLine());
            if (bolen==0 )
            {
                Console.WriteLine("Sonuç Belirsizdir");
                Console.ReadLine();
            }
            else
            {
                bolum = bolunen / bolen;
                Console.WriteLine("Çıkan Bölüm: {0}", bolum); //vayyy 
                Console.ReadLine();
            }
            

            // bolen 0 olduğunda program hata veriyor

            // mesela bolunen 1 bolen 4 olduğunda sonucu 0 veriyor ama sonuç 0.25

            //bu iki hatayı düzeltmeni bekliyorum

        }
    }
}
