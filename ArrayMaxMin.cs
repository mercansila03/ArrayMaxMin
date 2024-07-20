using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int enbuyuk = int.MinValue;
            int enkucuk = int.MaxValue;
            int toplam = 0;

            for (int i=0;i < sayilar.Length; i++)
            {
                Console.Write(i + 1 + ".sayıyı giriniz: ");
                int girilen=Convert.ToInt32(Console.ReadLine());
                toplam += girilen;
                if (girilen >enbuyuk){

                    enbuyuk = girilen ;
                }
                else if (girilen < enkucuk){

                    enkucuk = girilen;
                }                         
                
            }            
            
            Console.WriteLine("Dizinin en büyük elemanı: " +enbuyuk );
            Console.WriteLine("Dizinin en küçük elemanı: " + enkucuk);
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadKey();


        }
    }
}
