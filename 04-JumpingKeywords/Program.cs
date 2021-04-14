using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JumpingKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue
            //break
            //return

            //for (int i = 1; i <10; i++)
            //{
            //    if (i==5)
            //    {
            //        continue;// i==5 olduğunda 5'i atlar ve döngüye 6' dan kaldığı yerden devam eder.
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <10; i++)
            //{
            //    if (i==5)
            //    {
            //        break; // koşul sağlanıp break anaktar kelimesi okunduğu yerde döngü biter (kırılır) ve döngü dışına çıkar... 

            //    }
            //    Console.WriteLine(i);// 5 okunmaz döngü 4 de sonlanır bir alt scope geçer
            //}

            //Console.WriteLine("Beni Oku");//döngü 5 e geldiğinde direk bu alana gelir ve kod akışı buradan devam eder..

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} {j}");
            //        if (j == 4)
            //        {
            //            break; //j 4 e geldiğinde kesiliyor kesinlikle j 5 olmuyor fakat bir dıştaki for döngüsüne çıktığı için i koşulu bitene kadar sağlanıyor..
            //        }

            //    }
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        return;//Koşul sağlanır sağlanmaz sayfanın en altında bulunan scope dışına çıkar yani sayfadan atar...
            //    }
            //}
            //Console.WriteLine("Beni Oku");//Bu alan okunmaz..

            Console.ReadKey();
        }
    }
}
