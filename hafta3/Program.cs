using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Resule giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            if (sayi1 > 0)
            {
                Console.WriteLine($"girdiğiniz {sayi1} sayısı pozitiftir");
            }
            else if (sayi1 <0)
            {
                Console.WriteLine($"girdiğiniz {sayi1} sayısı negatiftir");
            }
            else
            { 
                Console.WriteLine($"lütfen bir tam sayı giriniz");
            }
            

        }
    }
}
