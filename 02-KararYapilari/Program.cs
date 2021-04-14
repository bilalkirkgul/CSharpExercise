using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region KARAR YAPILARI

            /* KARAR YAPILARI
             * if else
             * ternary if
             * switch case
             */

            //if (kosul)
            //{
            //    kosul = true;
            //}
            //else
            //{
            //    kosul = false;
            //}

            //if (kosul)
            //{

            //}
            //else if (kosul)
            //{

            //}
            //else
            //{

            //} 
            #endregion

            //if(){} - else if(){} - else{} 


            #region Kullanıcıdan alınan sayı 3' e tam bölünüyor mu ? bölünüyor ise Kullanıcıya sayi 3'e tam bölünüyor, bölünmüyorsa sayi 3'e tam bölünmüyor çıktısı verin

            //Console.WriteLine("Sayı değeri giriniz");
            //int value = int.Parse(Console.ReadLine());

            //if (value%3==0)
            //{
            //    Console.WriteLine("Girilen sayı 3'e tam bölünüyor ");
            //}
            //else Console.WriteLine("Girilen sayı 3'e tam bölünmüyor ");


            #endregion

            #region  Kullanıcıdan iki vize bir final notu alın. Vizelerin %30'u finalin %40 dahil edilerek oluşturulan yıl sonu notu derecelendirmesi aşağıdaki gibidir. 
            //30 45 DC
            //45 60 CC
            //60 80 BB
            //80 90 BA
            //90 100 AA 

            //Console.WriteLine("Birinci vize notunuzu giriniz");
            //double vize1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci vize notunuzu giriniz");
            //double vize2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Final notunuzu giriniz");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double sonuc = ((vize1 + vize2) * 0.30) + (final * 0.4);

            //if (sonuc>30&&sonuc<=45)
            //{
            //    Console.WriteLine("Harf notunuz DC'dir");
            //}
            //else if (sonuc>45&&sonuc<=60)
            //{
            //    Console.WriteLine("Harf notunuz CC'dir");
            //}
            //else if (sonuc > 60 && sonuc <= 80)
            //{
            //    Console.WriteLine("Harf notunuz BB'dir");
            //}
            //else if (sonuc > 80 && sonuc <= 90)
            //{
            //    Console.WriteLine("Harf notunuz BA'dir");
            //}
            //else if (sonuc > 90 && sonuc <= 100)
            //{
            //    Console.WriteLine("Harf notunuz AA'dir");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen notlara ait harf notu bulunamadı");
            //}


            #endregion

            #region Kullanıcı giriş yaptığında girdiği verilere göre özel çıktılar alsın

            //kullanıcı adı yanlışsa "Kullanıcı adınızı kontrol edin"
            //şifre yanlışsa "Şifrenizi kontrol edin"
            //hem kullanıcı adı hem şifre yanlışsa "tüm verileri kontrol edin"
            //kullanıcı adı şifre doğru ise "Giriş yapıldı" 

            // admin / qwert
            //Console.WriteLine("Kullanıcı adı giriniz");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Parola giriniz");
            //string password = Console.ReadLine();

            //if (userName=="admin")
            //{
            //    if (password=="qwert")
            //    {
            //        Console.WriteLine($"{userName} Giriş Yapıldı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifrenizi kontrol edin");
            //    }
            //}
            //else
            //{
            //    if (password=="qwert")
            //    {
            //        Console.WriteLine("Kullanıcı adınızı kontrol edin");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tüm verileri kontrol edin");
            //    }
            //}


            #endregion

            #region  Kullanıcı üç adet ürünü internetten alsın. Eger ürün fiyatları toplamı 150 tl geçerse kargo ücretsizdir. Aksi taktirde her alışveriş için şipariş tutarının %2 kargo ücreti ödenmelidir.  

            //Console.WriteLine("Birinci ürünün fiyatını giriniz");
            //double urun1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci ürünün fiyatını giriniz");
            //double urun2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üçüncü ürünün fiyatını giriniz");
            //double urun3 = Convert.ToDouble(Console.ReadLine());

            //double toplam = urun1 + urun2 + urun3;
            //if (toplam<=150)
            //{
            //    toplam *= 1.02;
            //    //toplam = toplam + toplam * 0.02;
            //    Console.WriteLine($"Ödemeniz gereken tutar {toplam} tl");
            //}
            //else
            //{
            //    Console.WriteLine($"Ödemeniz gereken tutar {toplam} tl");
            //}
            #endregion

            #region Kullanıcıdan iki sayi degeri ve bu iki sayı ile hangi işlem yapılacağı bilgisi (+ - / * %) alınacak. Bu bilgilere dayanarak işlemin sonucunu çıktı olarak verilecek

            //Console.WriteLine("sayi 1 : ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sayi 2 : ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İşlem Seçin \nToplama için + ya basınız\nÇarpma için * basınız\nÇıkarma için - basınız\nBölme için / basınız.\nMod için % basınız");
            //char myOperator = Convert.ToChar(Console.ReadLine());
            //double sonuc = 0;
            //if (myOperator == '+')
            //{
            //    sonuc = number1 + number2;
            //}
            //else if (myOperator == '-')
            //{
            //    sonuc = number1 - number2;
            //}
            //else if (myOperator == '*')
            //{
            //    sonuc = number1 * number2;
            //}
            //else if (myOperator == '/')
            //{
            //    sonuc = number1 / number2;
            //}
            //else if (myOperator == '%')
            //{
            //    sonuc = number1 % number2;
            //}
            //else
            //{
            //    Console.WriteLine("böyle bir işlem yok");
            //}
            //Console.WriteLine($"{number1} {myOperator} {number2} = {sonuc}"); 
            #endregion

            //SwicthCase

            #region Hesap Makinesi

            //Console.WriteLine("Sayı giriniz");
            //double sayi1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sayı giriniz");
            //double sayi2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("İşlem giriniz");
            //char islem = Convert.ToChar(Console.ReadLine());
            //double sonuc = 0;

            //switch (islem)
            //{
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        break;
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        break;
            //    case '%':
            //        sonuc = sayi1 % sayi2;
            //        break;
            //    case '/':
            //        sonuc = sayi1 / sayi2;
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        break;
            //    default:
            //        Console.WriteLine("Tanımla böyle bir işlem yoktur");
            //        break;
            //}
            //Console.WriteLine($"İşlem Sonucu : {sonuc}");

            #endregion

            #region Mevsimler - Kullanıcıdan sayı ile kaçıncı ayda olduğumuz bilgisi alınacak ve ay bilgisine göre hangi mevsimde olduğumuzu çıktı olarak vereceğiz


            //Console.WriteLine("Bulunduğumuz Ay'ı sayı ile belirtiniz");
            //int ay = int.Parse(Console.ReadLine());

            //switch (ay)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar");
            //        break;
            //    default:
            //        Console.WriteLine("Böyle bir ay bulunmamaktadır");
            //        break;
            //}



            #endregion

            #region Planlama - Bir iş yerinde çalışanlar gün ve sabah akşam bilgisi girerek o gün yapacakları işi çıktı olarak alıyorlar
        
            //pazartesi sabah fiziksel Introduction akşam online OOP
            //salı sabah işkur DataAccess akşam online OOP
            //çarşamba sabah online OOP akşam onlineOOP
            //perşembe sabah fiziksel Introduction akşam işkur DataAccess
            //cuma tatil
            //cumartesi online MVC akşam boş
            //pazar online MVC akşam işkur DataAccess 

            //Console.WriteLine("Rakamla Gün Seçiniz (1-P.tesi) (2-Salı) (3-Çarşamba) (4-Perşembe) (5-Cumar) (6-C.tesi) (7-Pazar)");
            //int gun = int.Parse(Console.ReadLine());
            //Console.WriteLine("Rakamla Zaman Seçiniz (1-Öğleden Önce) (2-Öğleden Sonra)");
            //int zaman = int.Parse(Console.ReadLine());
            //string mesaj = string.Empty;

            //if (zaman==1)
            //{
            //    switch (gun)
            //    {
            //        case 1:
            //        case 4:
            //            mesaj = "fiziksel Introduction";
            //            break;
            //        case 2:
            //            mesaj = "işkur DataAccess";
            //            break;
            //        case 3:
            //            mesaj = "online OOP";
            //            break;
            //        case 5:
            //            mesaj = "Tatil";
            //            break;
            //        case 6:
            //        case 7:
            //            mesaj = "online MVC";
            //            break;
            //        default:
            //            mesaj = "Böyle bir gün yok";
            //            break;

            //    }
            //}
            //else if(zaman==2)
            //{
            //    switch (gun)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //            mesaj = "online OOP";
            //            break;
            //        case 4:
            //        case 7:
            //            mesaj = "işkur DataAccess";
            //            break;
            //        case 5:
            //        case 6:
            //            mesaj = "Tatil";
            //            break;
            //        default:
            //            mesaj = "Böyle bir gün yok";
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir zaman dilimi yok");
            //}
            //Console.WriteLine(mesaj);

            #endregion


            Console.ReadKey();
        }

    }
}


