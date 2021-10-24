using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] sehirler = new string[4]; //Dört elemanlı bir dizi oluşturuldu. Dizilerin elemanları indexinde tutulur. İlk index 0'a denk gelir..
            //sehirler[0] = "İstanbul";
            //sehirler[1] = "Ankara";
            //sehirler[2] = "İzmir";
            //sehirler[3] = "Bursa";

            ////sehirler[4] = "Antalya"; [4] nolu bir index olmadığı için içerisine değer ataması yapamayacağımız için hata alırız..

            //int[] sayilar = new int[4] { 4, 8, 10,11 };

            //double[] ondalikSayilar = new double[3] { 10.5, 3.9, 8.5 };

            //char[] karakterler = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            //string[] gunler =new string[7] { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };

            //string[] haftaninGunleri = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };


            //Console.WriteLine(haftaninGunleri.Length); //Dizi içerisindeki eleman sayısını verir.

            //Donguler ile Dizi Kullanımı

            //for (int i = 0; i < haftaninGunleri.Length; i++)
            //{
            //    Console.WriteLine(haftaninGunleri[i]);
            //}

            //int sayac = 0;

            //while (sayac <= haftaninGunleri.Length - 1) //Dizi içerisinde olan elemanları yazdırmak istiyoruz. index her zaman 0 dan başladığı için length-1 almalıyız..
            //{
            //    Console.WriteLine(haftaninGunleri[sayac]);
            //    sayac++;
            //}

            //foreach (string item in haftaninGunleri)
            //{
            //    Console.WriteLine(item);
            //}


            #region Beş elemanlı string dizi oluşturup bu diziye değer atalım ve devamında ekrana çıktısını verelim..

            //string[] isimler = new string[5];

            //isimlerin length = 5 i 0 dan başladığı için index 4 olduğunda aslında dizi içerisinde 5 eleman olmuş oluyor o yüzden i 5' den küçük olmalıdır.. 

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İsim giriniz");
            //    isimler[i] = Console.ReadLine();
            //    Console.Clear();
            //}

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            //int sayac = 0;

            //while (sayac<isimler.Length)
            //{
            //    Console.WriteLine("İsim giriniz");
            //    isimler[sayac] = Console.ReadLine();
            //    sayac++;
            //    Console.Clear();
            //}

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Kullanıcıdan bir metin ve bir karakter alınacak, metin içerisinde alınan karakter kaç adet geçiyor çıktı olarak verilecek (ışık ılık süt iç ,ı => 4 adet ı var) şeklinde..

            //her string ifade char dizisidir..


            int sayac = 0;

            Console.WriteLine("Metin giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("Karakter giriniz");
            char karakter = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (karakter == metin[i])
            //    {
            //        sayac++;
            //    }
            //}

            foreach (char item in metin)
            {
                if (item == karakter)
                {
                    sayac++;
                }
            }

            Console.WriteLine($"{metin} metin içerisinde \n{karakter} Karakteri\nToplamda {sayac} adet vardır");

            #endregion

            #region Kullanıcıdan alınan metni ters cevirip yazma işlemi. Ali ilA

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();

            //for (int i = metin.Length-1; i >=0; i--)
            //{
            //    Console.Write(metin[i]);
            //}



            #endregion

            #region Rastgele 1-100 arası 20 sayıdan oluşan bir dizi oluşturulacak, bu dizideki çift sayılar listelenecek ve bu çift sayılarından 3' e bölünen sayıların adetini çıktı olarak ekrana verilecek..

            //int[] sayilar = new int[20];
            //Random random = new Random();
            //string sayiListesi = string.Empty;
            //int sayac = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = random.Next(1, 101);
            //    sayiListesi += sayilar[i] + " ";
            //}

            //Console.WriteLine(sayiListesi);

            //foreach (var item in sayilar)
            //{
            //    if (item%2==0)
            //    {
            //        Console.WriteLine(item);

            //        if (item%3==0)
            //        {
            //            sayac++;
            //        }
            //    }
            //}

            //Console.WriteLine($"Çift sayılar içerisinde 3' e bölünen sayı adedi :{sayac}");

            #endregion


            Console.ReadKey();

        }
    }
}
