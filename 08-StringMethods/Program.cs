using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Bilal Kırkgül";

            #region Metin karakter uzunluğu
            //Console.WriteLine(text.Length); 
            #endregion

            #region metin parametreyi içeriyor mu ?

            //if (text.Contains("i"))
            //{
            //    Console.WriteLine("içeriyor");
            //}
            //else
            //{
            //    Console.WriteLine("içermiyor");
            //}



            #endregion

            #region metnin karakterini veya karakter parçasını değiştirme

            //string fullName=text.Replace("Bilal", "Hilal");

            //Console.WriteLine(text.Replace("Bilal", "Hilal"));
            //Console.WriteLine(fullName);

            //Console.WriteLine(text.Replace('B','N'));


            #endregion

            #region Metnin bir parçasını alma işlemi.

            //Console.WriteLine(text.Substring(2,5)); //index 2 den başla 5 karakter al


            #endregion

            #region Kullanıcıdan alınan metinsel ifade Ada veya ada veya aDa vaya ADA veya adA veya ADa ise giriş yapılsın değil ise giriş yapılamasın

            //Console.WriteLine("Metin Giriniz");
            //string metin = Console.ReadLine();

            //if (metin.ToLower()=="ada")
            //{
            //    Console.WriteLine("giriş yapıldı");
            //}
            //else Console.WriteLine("Hatalı giriş yapıldı");



            #endregion

            #region Kullanıcıdan bir şifre alınsın bu şifre içerisinde ^+%&/()= ifadelerinden en az birini içermek zorundadır. İçeriyorsa şifreniz kabul edildi içermiyorsa şifreniz kabul edilmedi çıktısı alınsın.

            //Console.WriteLine("Şifre giriniz");
            //string password = Console.ReadLine();
            //bool check = false;
            //string karakter = "^+%&/()=";

            //foreach (char item in password)
            //{
            //    if (karakter.Contains(item))
            //    {
            //        check = true;
            //        break;
            //    }

            //}

            //if (check)
            //{
            //    Console.WriteLine("Şifreniz kabul edildi");
            //}else Console.WriteLine("Şifreniz Kabul edilmedi");




            #endregion

            #region Kullanıcıdan bir urun adı ve bir ürün kodu alın ürün kodu ürünün ilk iki harfi ve ürünadının eleman sayısından oluşmalıdır.Doğru kodu girerse urun kodu doğru bilgisi verin //ÜrünAdi : Çay =>ÜrünKodu ÇA3

            //Console.WriteLine("Ürün adı giriniz");
            //string urun = Console.ReadLine();
            //Console.WriteLine("ürün kodu giriniz");
            //string urunKodu = Console.ReadLine();

            //string dogruKod = urun.Substring(0, 2).ToUpper() + urun.Length;

            //if (dogruKod==urunKodu)
            //{
            //    Console.WriteLine("Kod doğru");
            //}
            //else Console.WriteLine("Hatalı kod girildi");


            #endregion
            #region Kullanıcıdan bir metin ifadesi birde karakter alın o metin içerisindeki o karakterleri yok edin bilal kirkgul - i => Blal krkgul

            //Console.WriteLine("Metin giriniz");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Karakter giriniz");
            //string karakter =Console.ReadLine();

            //Console.WriteLine(metin.Replace(karakter,""));


            #endregion

            #region Kullanıcıdan bir adres bilgisi alın bu adres içerisinde Posta Kodu bilgisinin geçtiğinden emin olun Geçmiyor ise lütfen posta kodu bilgisinizi belirtin çıktısı verin.

            //pk=Posta kodu

            //Console.WriteLine("adres bilgisi giriniz");
            //string adres = Console.ReadLine();

            //if (adres.Contains("pk")||adres.Contains("PK"))
            //{
            //    Console.WriteLine("adres bilgisi doğru");
            //}
            //else
            //{
            //    Console.WriteLine("eksik adres bilgisi giridiniz");
            //}


            #endregion

            #region ali-ayşe-mehmet-yasemin-ahmet-fatma isim listesindeki degerler baş harfi buyuk diğer harfleri küçük olacak şekilde alt alta listeleyin 

            //string deger = "ali-ayŞe-mehmEt-yaseMin-ahmet-fatma";
            //string[] isimDizisi = deger.Split('-');

            //foreach (string item in isimDizisi)
            //{
            //    Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower());
            //}




            #endregion

            Console.ReadKey();
        }
    }
}
