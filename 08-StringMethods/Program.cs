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


            Console.ReadKey();
        }
    }
}
