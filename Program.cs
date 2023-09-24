using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1' den başlayıp kullanıcının girdiği sayıya kadar olan sayıların toplam ve ortalamasını yazdıralım.
            /*
            int sayi, toplam = 0;
            Console.Write("Bir Sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            double ortalama = (double)toplam / sayi;
            Console.WriteLine("Toplamın sonucu: " +toplam);
            Console.WriteLine("Sayıların ortalaması: "+ortalama);
            */
            /*
            int toplam = 0;
            int kullaniciSayi;
            Console.Write("Bir sayı giriniz: ");
            kullaniciSayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= kullaniciSayi; i++)
            {

                toplam += i;
            }
            double ortalama = (double)toplam / kullaniciSayi;
            Console.WriteLine("1'den girdiğiniz sayıya kadar olan sayıların toplamı: "+toplam);
            Console.WriteLine("Sayıların ortalaması: "+ortalama);
            */

            // 1' den başlayıp kullanıcının girdiği sayıya kadar olan sayıların
            //2'ye bölünebilenlerini ekrana yazdıralım

            /*
            int sayi;
            Console.Write("Bir sayı girin: ");
            sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("2 ye bölünebilen sayılar: "+i);
                }
            }
            */
            /*
            int kullaniciSayi;
            Console.Write("Bir sayı giriniz: ");
            kullaniciSayi = int.Parse(Console.ReadLine());

            for (int sayac = 1; sayac <= kullaniciSayi; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    Console.WriteLine(sayac+" sayısı 2'ye tam bölünüyor. ");

                }
                else
                {
                    Console.WriteLine(sayac+" sayısı 2 'ye tam bölünmüyor");
                }



            }
*/

            // Kullanıcı pozitif bir sayı girene kadar kullanıcıdan sayı isteyelim.
            //1 'den başlayıp kullanıcının girdiği sayıya kadar olan sayıların çift olanlarını ekrana yazdıralım.

            int kullaniciSayi;

            do
            {
                Console.Write("Bir sayı giriniz: ");
                kullaniciSayi = int.Parse(Console.ReadLine());
                if (kullaniciSayi<0)
                {
                    Console.WriteLine("Negatif bir sayı giremezsiniz.");
                    Console.WriteLine("Lütfen pozitif bir sayı girin.");

                }
                else
                {

                    for (int sayac = 1; sayac < kullaniciSayi; sayac++)
                    {
                        if (sayac%2==0)
                        {
                            Console.WriteLine(sayac+" sayısı 2'ye tam bölünüyor.");
                        }
                        else
                        {
                            Console.WriteLine(sayac+" sayısı 2'ye tam bölünmüyor.");


                        }



                    }


                }
            } while (kullaniciSayi<0);
            Console.ReadKey();
        }
    }
}
