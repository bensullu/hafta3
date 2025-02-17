using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hoşgeldiniz K.Adı Giriniz");
            string kgiris = "suleyman";
            string usname = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz");
            string ksifre = "1234";
            
            string uspass=Console.ReadLine();
            if (usname == kgiris && ksifre == uspass)
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else
            {
                Console.WriteLine("K.Adı veya Şifre Hatalı!");
            }*/
            Console.WriteLine("Hoşgeldiniz İki Adet Çift Tam Sayı Giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("diğer tam sayıyı giriniz ");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            if (sayi1 % 2 == 0 || sayi1 % 2 == 0)
            {
                Console.WriteLine($"{sayi1} ile {sayi2} nin çarpımı= {sayi2 * sayi1}");
            }
            else
            {
                Console.WriteLine("en az bir adet çift sayı giriniz");
            }


        }
    }
}
