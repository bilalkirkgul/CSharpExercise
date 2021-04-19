using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Loops_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 farklı döngü yapımız vardır
            //for
            //while
            //doWhile
            //foreach

            #region 1' den 100' e kadar olan sayıların toplamı kaçtır ?

            //int toplam = 0;

            ////for (int i = 1; i <= 100; i++)
            ////{
            ////    toplam += i;
            ////}

            //int sayac = 0;

            //while (sayac<=100)
            //{
            //    toplam += sayac;
            //    sayac++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region 1' den 100' e kadar olan tek sayılarla çift sayıların farkı kaçtır ?

            //int tek = 0;
            //int cift = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        cift += i;
            //    }
            //    else
            //    {
            //        tek += i;
            //    }
            //}

            //int sayac = 0;
            //while (sayac<=100)
            //{
            //    if (sayac%2==0)
            //    {
            //        cift += sayac;

            //    }
            //    else
            //    {
            //        tek += sayac;
            //    }
            //    sayac++;
            //}

            //Console.WriteLine($"Tek sayılar toplamı : {tek}\nÇift sayılar toplam : {cift}\nFark : {cift-tek} ");
            #endregion

            #region iç içe döngü aşağıdaki görüntüyü ekrana yazdırma

            /*
                a=>1
                b=>1
                c=>1
                a=>2
                b=>2
                c=>2
                a=>3
                b=>3
                c=>3               
               */

            //for (int i = 1; i <=3; i++)
            //{
            //    for (char j = 'a'; j <='c' ; j++)
            //    {
            //        Console.WriteLine($"{j}=>{i}");
            //    }
            //}



            #endregion

            #region 1'den 10'a kadar Çarpım tablosunu listeleyelim ?


            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        Console.WriteLine($"{j}x{i}={j*i}");
            //    }
            //}





            #endregion

            #region 3 haklı Kullanıcı Login giriş paneli 

            //Kullanıcı adı admin
            //Şifre : 1234

            //Kullanıcıdan bir kullanıcı adı bir şifre alınacak. Kullanıcının 3 hakkı var. Kullanıcı 3 kez bilgilerini yanlış girerse çıktı olarak hesabınız kilitlendi uyarısı alacak. ilkinde yanlış girerse ikinci ikincide yanlış girerse üçüncü kez bilgi girmesini sağlanacak..

            //bool check = false;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{3-i} hakkınız kaldı");
            //    Console.WriteLine("Kullanıcı adınızı giriniz");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("Parolanızı giriniz");
            //    string password = Console.ReadLine();

            //    if (userName=="admin"&&password=="1234")
            //    {
            //        check = true;
            //        i = 5;
            //    }

            //}
            //if (!check)
            //{
            //    Console.WriteLine("Giriş Hakkınız kalmadı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}


            #endregion

            #region Kullanıcıdan kullanıcı adı ve password alınacak. Kullanıcı doğru girene kadar sormaya devam edecek kod hazırlanacak..

            // While Kullanımı


            //Console.WriteLine("Kullanıcı Adı Giriniz");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Sifre Giriniz");
            //string password = Console.ReadLine();

            //while (userName != "admin" || password != "123")
            //{
            //    Console.WriteLine("Yanlış Giriş");
            //    Console.WriteLine("Kullanıcı Adı Giriniz");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("Sifre Giriniz");
            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("Doğru Giriş Yapıldı");



            // do While Kullanımı

            //string userName = string.Empty;
            //string password = string.Empty;

            //do
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("Parola Giriniz");
            //    password = Console.ReadLine();

            //} while (userName != "admin" || password != "123");

            //Console.WriteLine($"{userName} Hoşgeldiniz");

            #endregion

            #region Kullanıcı tamam diyene kadar girdiği sayılar karşılaştırılacak. Tamam dediğinde en büyük olanı çıktı olarak verilecek. Döngü sadece tamam denildiğinde sonlansın


            //string value = string.Empty;
            //int max = 0;

            //do
            //{
            //    Console.WriteLine("Değer giriniz");
            //    value = Console.ReadLine();
            //    bool check = int.TryParse(value, out int sayi);
            //    if (check && sayi>max)
            //    {
            //        max = sayi;
            //    }

            //} while (value!="tamam");

            //Console.WriteLine($"Kullanıcının girmiş olduğu en büyük sayı :{max}");

            #endregion

            #region Kullanıcı rakamla '0' girene kadar kullanıcının girdiği tüm sayıları toplayıp ekrana çıktısı verilecek. 

            //int toplam = 0;
            //string value = string.Empty;
            //do
            //{
            //    Console.WriteLine("Değer giriniz");
            //    value = Console.ReadLine();
            //    bool check = int.TryParse(value, out int sayi);
            //    if (check)
            //    {
            //        toplam += sayi;
            //    }
            //} while (value!="0");
            //Console.WriteLine($"Kullanıcının girmiş olduğu sayıların toplamı : {toplam}");

            #endregion

           
            #region Kullanıcıdan alınan metni ters cevirip yazılacak.  Ali ilA

            //Console.WriteLine("metin giriniz");
            //string value = Console.ReadLine();


            //for (int i = value.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(value[i]);
            //} 
            #endregion



            Console.ReadKey();
        }
    }
}
