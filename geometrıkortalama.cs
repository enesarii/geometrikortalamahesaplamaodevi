using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrikortalamahesaplamaodev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 2 sayının geometrik ortalaması alınır
            // küsürat yüzünden double veri tipi kullanılır
            // redline ve dobule aynı anda çalışmaz diye convert ile double'ye çevirdim

            Console.WriteLine("İlk sayiyi girin:");

            Double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayiyi girin:");

            Double sayi2 = Convert.ToDouble(Console.ReadLine());

            Double sayi3 = Convert.ToDouble(Math.Sqrt(sayi1 * sayi2));

            // Sonuç yazılcak
            
            Console.WriteLine("sonuç:");

            Console.WriteLine(sayi3);

            // Terminalin ekranda kalması için.
            Console.ReadLine();
        }
    }
}