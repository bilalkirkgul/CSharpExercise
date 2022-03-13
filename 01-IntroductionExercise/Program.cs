using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IntroductionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan iki adet ürün fiyatı alınacak. Bu urunlere toplam ne kadar ödeme yapılmış kdv dahil hariç ve kdv tutarı belirtilecek...(Kdv oranı 18'dir)
            //Console.WriteLine("Birinci ürün fiyatı giriniz");
            //decimal fiyat1 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("İkinci ürün fiyatı giriniz");
            //decimal fiyat2 = Convert.ToDecimal(Console.ReadLine());

            //double toplam = Convert.ToDouble(fiyat1 + fiyat2);

            //Console.WriteLine($"Kdv Hariç Toplam Tutar: {toplam}\nKdv Tutarı: {toplam * 0.18}\nKdv Dahil Toplam Tutar: {toplam += toplam * 0.18}");
            #endregion

            #region Kullanıcıdan alınan iki sayının kareleri toplamı kaçtır ?
            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int karelerToplami = (sayi1 * sayi1) + (sayi2 * sayi2);

            ////Console.WriteLine(karelerToplami);
            //Console.WriteLine($"{(sayi1*sayi1)+(sayi2*sayi2)}"); 
            #endregion

            #region Kullanıcıdan bir ad ve bir soyad bilgisi alın ad.soyad@gmail.com mailini oluşturun ve çıktı olarak verin.


            //Console.WriteLine("Adınızı giriniz");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Soyadınızı giriniz");
            //string lastName = Console.ReadLine();

            //string mail = firstName + "." + lastName + "@gmail.com";

            ////Console.WriteLine(mail);

            //Console.WriteLine($"{firstName}.{lastName}@gmail.com");


            #endregion

            #region  Girilen iki sayının toplamının farkına bölümünden kalan kaçtır ?

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sonuc = ((sayi1 + sayi2) % (sayi1 - sayi2));

            //Console.WriteLine($"Blümünden kalan {sonuc}");

            #endregion

            #region Boolen kullanılarak username ve password kontrolü (true/false)

            //username=bilal password=qwert

            //Console.WriteLine("Kullanıcı adı giriniz");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Password giriniz");
            //string password = Console.ReadLine();

            //bool check = userName == "bilal" && password == "qwert";

            //Console.WriteLine(check);


            #endregion

            #region Kullanıcıdan alınan sayının 10 eksiğinin 5e bölümünden kalanının 10 fazlası kaçtır?

            //Console.WriteLine("Sayı giriniz");
            //int value = int.Parse(Console.ReadLine());
            //int sonuc = ((value - 10) % 5) + 10;
            //Console.WriteLine(sonuc);

            #endregion

            #region Kullanıcıdan bir sayı alınacak tek ise false çift ise true dönün

            //Console.WriteLine("Sayı giriniz");
            //int value = int.Parse(Console.ReadLine());
            //bool sonuc = value % 2 == 0;

            //Console.WriteLine(sonuc);


            #endregion

            #region Kullanıcıdan üç ürün fiyatı alınacak ve bu üç ürünün toplam fiyatı 100 TL' den fazla ise true değilse false dönün.

            //Console.WriteLine("Birinci ürün fiyatını giriniz");
            //decimal fiyat1 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("İkinci ürün fiyatını giriniz");
            //decimal fiyat2 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Üçüncü ürün fiyatını giriniz");
            //decimal fiyat3 = Convert.ToDecimal(Console.ReadLine());

            //decimal genelToplam = fiyat1 + fiyat2 + fiyat3;

            //bool check = genelToplam > 100;
            //Console.WriteLine(check);


            #endregion

            #region Bankada 100 tl var. Kullanıcı kaç tl para çekmek istediğini bilgi olarak giriyor. Bankada yeterli para varsa true yoksa false dönün 

            //decimal bakiye = 100;
            //Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
            //decimal tutar = Convert.ToDecimal(Console.ReadLine());
            //bool check = bakiye >= tutar;
            //Console.WriteLine(check);

            #endregion

            //Console.WriteLine(FirstFactorial(Console.ReadLine()));

            Console.WriteLine(FirstReverse(Console.ReadLine()));



            Console.ReadKey();
        }

        static int FirstFactorial(int num)
        {
            for (int i = num-1; i >= 1; i--)
            {
                num *= i;
            }
            return num;
        }

        static string FirstReverse(string str)
        {
            string value = string.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {

                value += str[i];
            }
            str = value;
            return str;
        }

    }
}
