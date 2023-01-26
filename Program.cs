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
            int bolunen, bolen, bolum;

            Console.WriteLine("Lütfen Bölünen Sayıyı Giriniz");
            bolunen = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Bölen Sayıyı Giriniz");
            bolen = Int32.Parse(Console.ReadLine());

            bolum = bolunen / bolen;

            Console.WriteLine("Çıkan Bölüm: {0}", bolum);
            Console.ReadLine();

        }
    }
}
