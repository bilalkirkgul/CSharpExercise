using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //string sayiListesi = "12 3 4 8 11 9 7 6 5 48 69 881";

            //List<int> sayilar = new List<int>();

            //foreach (var item in sayiListesi.Split(' '))
            //{
            //    sayilar.Add(int.Parse(item));
            //}

            //int toplam = 0;

            //foreach (int item in sayilar)
            //{
            //    toplam += item;
            //}
            //Console.WriteLine(toplam);


            //Kullanıcıdan rasgele sayılar alınacak bu sayıların en büyüğü kullanıcı ok dediğinde çıktı olarak vereceğiz...


            //List<int> sayiDizisi = new List<int>();
            //int[] sayiArray = new int[5];

            //string value = string.Empty;



            //for (int i = 0; i < sayiArray.Length; i++)
            //{
            //    Console.WriteLine("Değer giriniz");
            //    value = Console.ReadLine();
            //    sayiArray[i] = int.Parse(value);

            //}

            
            //Array.Sort(sayiArray);
            //Array.Reverse(sayiArray);
            //int[] ilkUc = new int[3];
            //Array.Copy(sayiArray, ilkUc, 3);


            //for (int i = 0; i < ilkUc.Length; i++)
            //{
            //    Console.WriteLine(ilkUc[i]);
            //}



            int buyuk = 0;//değişken tanımlanıyor
            int buyuk2 = 0;//değişken tanımlanıyor
            int buyuk3 = 0;//değişken tanımlanıyor
            int[] sayi = new int[10];//dizi tanımlanıyor


            for (int i = 0; i <= sayi.Length; i++)// 10 adt sayının girilmesi için for döngüsü açılıyor
            {
                Console.Write("Lütfen Sayıları Giriniz : ");
                sayi[i] = Convert.ToInt32(Console.ReadLine());//girilen değerler int e çevriliyor
            }
            for (int i = 0; i < sayi.Length; i++)
            {
                //en büyük sayıyı bulmak için sayılar buyuk değişkeni ile karşılaştırılıyor eğer(if) büyük ise sayıdan buyuk değişkenine aktarılıyor       

                if (buyuk < sayi[i])
                { buyuk = sayi[i]; }

            }

            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] == buyuk)
                {//en büyük 2.sayıyı bulmak için yine aynı işlem yapılıyor 
                    i++;//en büyük sayı değeri geldiğinde pas geçiliyor
                }
                else if (buyuk2 < sayi[i])
                { buyuk2 = sayi[i]; }

            }
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] == buyuk || sayi[i] == buyuk2)
                {//en büyük 2.sayıyı bulmak için yine aynı işlem yapılıyor 
                    i++;//en büyük sayı değeri ve en büyük 2.sayı geldiğinde pas geçiliyor
                }
                else if (buyuk3 < sayi[i])
                {
                    buyuk3 = sayi[i];
                }
            };

            Console.WriteLine("En büyük 1. sayı:{0}", buyuk);
            Console.WriteLine("En büyük 2. sayı:{0}", buyuk2);
            Console.WriteLine("En büyük 3. sayı:{0}", buyuk3);
            int ortalama;
            Console.Write(ortalama = (buyuk + buyuk2 + buyuk3) / 3);//sayıların ortalaması alınıyor



            Console.ReadKey();

        }










    }
}
