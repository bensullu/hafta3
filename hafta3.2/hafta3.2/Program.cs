using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3._2
{
    internal class Program
    {
        static void Main(string[] args)
        { //tek satırda if

            //Console.Write("kullanıcının girdiği sayı pozitif mi degil mi ? ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string result = (sayi > 0) ? "Pozitif Sayı" : "Negatif Sayı"; //onemli formul
            //Console.Write(result);

            //girilen bir sayı int tipindeyse o sayının karesini alan program
            Console.WriteLine("lütfen bir sayı giriniz");
            string deger= Console.ReadLine();
            if(int.TryParse(deger, out int number))
            {
                if (number % 2==0)
                {
                    Console.WriteLine($"girdiğiniz {number} sayısının karesi = {number * number}");
                }
                else
                {
                    Console.WriteLine("lütfen çift sayı giriniz");
                }
                
            }
            else
            {
                Console.WriteLine("lütfen int tipinde bir sayı giriniz");
            }








        }
    }
}
