using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MethodIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Method oluştururken kendinize sormanız gerekn iki soru var
                    1) Method geriye deger dönecek mi ??? geriye değer dönüyorsa return kullanılır
                    2) Method bir degere ihtiyaç duyuyor mu? yani paramtre almalı mı ?
             */

            //string merhaba = MerhabaDe();
            //Console.WriteLine(merhaba);
            //Console.WriteLine(MerhabaDe());

            //Console.WriteLine(PiSayisi());

            //int value = 4;
            //Console.WriteLine(value*PiSayisi());

            //Console.WriteLine("kisa kenar giriniz");
            //int kisa = int.Parse(Console.ReadLine());
            //Console.WriteLine("uzun kenar giriniz");
            //int uzun = int.Parse(Console.ReadLine());
            //Console.WriteLine(DikdortgenAlan(kisa,uzun));

            //Merhaba();
            //Selam();

            //Console.WriteLine("değer giriniz");
            //string value = Console.ReadLine();
            //Yazdir(value);
            //TarihBilgisiVer();

            //Kullanıcıdan iki sayı alan ve toplamını çıktı olarak veren metotu oluşturun eğer ki kullacının girdiği degerlerden herhangi biri sayısal bir ifade değil ise çıktı olarak lütfen sayı girin dönün.

            //Console.WriteLine("sayi bir giriniz");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("sayi iki giriniz");
            //string value2 = Console.ReadLine();

            //Toplam(value1, value2);

            //Kare Alanı hesaplama işlemi

            //Console.WriteLine("Kare kenarı giriniz");
            //int kenar = int.Parse(Console.ReadLine());
            //Console.WriteLine(KareAlan(kenar));

            //Console.WriteLine("İsim giriniz");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("Soyisim giriniz");
            //string LastName = Console.ReadLine();

            //Console.WriteLine(FirstName+LastName+MailUzantisi());



            //Kullanıcıdan iki sayı alıp bu iki sayıdan buyuk olanı geri dönen metotu oluşturun.


            //Console.WriteLine("1. sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Kontrol(sayi1,sayi2));


            Console.ReadKey();
        }


        static int Kontrol(int s1,int s2)
        {
            if (s1 > s2)
            {
                return s1;
            }
            else return s2;
        }

        static string MailUzantisi()
        {
            return "@gmail.com";
        }

        static int KareAlan(int sayi)
        {
            return sayi * sayi;
        }

        static void Toplam(string s1,string s2)
        {
            int sayi1 = 0;
            int sayi2 = 0;

            bool kontrol1 = int.TryParse(s1, out sayi1);
            bool kontrol2 = int.TryParse(s2, out sayi2);
            if (kontrol1&&kontrol2)
            {
                Console.WriteLine(sayi1+sayi2);
            }
            else
            {
                Console.WriteLine("Lütfen sayi giriniz");
            }

        }


        //Geriye Deger Dönmeyen Parametreli Metot

        static void Yazdir(string name)
        {
            Console.WriteLine(name);
        }



        //Geriye deger dönmeyen parametresiz bir method
        static void TarihBilgisiVer()
        {
            Console.WriteLine($"{DateTime.Now}");
        }


        static void Selam()
        {
            string deger = MerhabaDe();
            Console.WriteLine(deger);
        }

        static void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }


        //Geriye deger dönen parametreli metot
        static decimal DikdortgenAlan(int kisaKenar,int UzunKenar)
        {
            return kisaKenar * UzunKenar;
        }


        //Geriye deger dönen parametresiz metot
        //geriye değer dönen method return edilmek zorundadır. 
        static string MerhabaDe()
        {
            return "Merhaba Bilal";
        }
        static decimal PiSayisi()
        {
            return 3.14m;
        }



    }
}
