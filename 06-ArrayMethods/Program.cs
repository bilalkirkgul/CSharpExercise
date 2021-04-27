using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] egitmenler = { "Gizem", "Rıdvan", "Fatih", "Sema", "Akın", "Hatice", "Rıdvan" };
            //int[] sayilar = { 34, 68, 76, 34768, 34, 90, 90, 87, 45, 5687, 90, 986, 5643, 4, 667, 89 };

            #region Eleman Sayısı

            //Console.WriteLine(egitmenler.Length);
            //Console.WriteLine(sayilar.Length); 

            #endregion

            #region Dizi elemanlarını (a-z 0-10) sıralama 

            //Array.Sort(egitmenler);

            //foreach (string item in egitmenler) //A' dan Z' ye sıralama işlemi
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(sayilar);

            //foreach (int item in sayilar) //0' dan ileriye (++) doğru sıralama işlemi
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dizi elemanlarının sırasını terse çevirme
            //Array.Reverse(sayilar);

            //foreach (int item in sayilar) // dizi içerisinde yer alan elemanları lenght-1 den 0 a sıralama işlemi yapar
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Reverse(egitmenler);
            //foreach (string item in egitmenler)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Eleman Silme İşlemi
            //Array.Clear(egitmenler,2,2); //egitmenler dizisinin 2. indexisnden başla 2 index sil 

            //foreach (string item in egitmenler)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Clear(sayilar, 1, 3); // int deger tipi olduğu için 1. indexden sonra gelen 3 elemanı siler fakat 0 değeri verir.

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dizi boyutunu azaltma arttırma 

            //kullanıcı ok diyene kadar girdiği değerleri diziye dahil etme işlemi gerçekleştirdim..

            //string[] sehirler = new string[0];
            //string value = string.Empty;

            //do
            //{
            //    Console.WriteLine("sehir adı giriniz");
            //    value = Console.ReadLine();
            //    Array.Resize(ref sehirler, sehirler.Length + 1);
            //    sehirler[sehirler.Length - 1] = value;

            //} while (value!="ok");

            //Array.Resize(ref sehirler, sehirler.Length - 1);
            ////Array.Clear(sehirler, sehirler.Length - 1, 1);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}


            //List<string> sehirler = new List<string>();
            //string sehir = string.Empty;

            //do
            //{
            //    Console.WriteLine("Şehir isimleri giriniz");
            //    sehir = Console.ReadLine();
            //    sehirler.Add(sehir);

            //} while (sehir!="ok");

            //sehirler.Remove("ok");

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Index Bulma
            //int firstIndex = Array.IndexOf(egitmenler, "Rıdvan"); //dizinin 0. indexinden başlar
            //int lastIndex = Array.LastIndexOf(egitmenler, "Rıdvan");//dizinin lenght-1 inden başlar ve aramaya devam eder.
            //Console.WriteLine(firstIndex);
            //Console.WriteLine(lastIndex);



            #endregion

            #region Elaman Kopyalama
            //string[] teachers = new string[egitmenler.Length];
            //Array.Copy(egitmenler, teachers, 5); //egitmenler dizisinin 0,1,2,3,4 indexinde yer alan değerleri kopyalayıp teachers dizisine aktardık..

            //foreach (string item in teachers)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            Console.ReadKey();
        }
    }
}
