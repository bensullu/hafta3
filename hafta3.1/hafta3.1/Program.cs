using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir gün adı giriniz");
            string gun=Console.ReadLine();

            if (gun.ToLower() =="pazartesi")
            {
                Console.WriteLine($"{gun} günü haftanın 1. günüdür");
            }
           else if (gun.ToLower() == "salı")
            {
                Console.WriteLine($"{gun} günü haftanın 2. günüdür");
            }
           else if (gun.ToLower() == "çarşamba")
            {
                Console.WriteLine($"{gun} günü haftanın 3. günüdür");
            }
           else if (gun.ToLower() == "perşembe")
            {
                Console.WriteLine($"{gun} günü haftanın 4. günüdür");
            }
           else if (gun.ToLower() == "cuma")
            {
                Console.WriteLine($"{gun} günü haftanın 5. günüdür");
            }
           else if (gun.ToLower() == "cumartesi")
            {
                Console.WriteLine($"{gun} günü haftanın 6. günüdür");
            }
           else if (gun.ToLower() == "pazar")
            {
                Console.WriteLine($"{gun} günü haftanın 7. günüdür");
            }
            else
            {
                Console.WriteLine($"{gun} geçerli bir gün adı değildir lütfen geçerli bir gün adı giriniz");
            }
        }
    }
}
