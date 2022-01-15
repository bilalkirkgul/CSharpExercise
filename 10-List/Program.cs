using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>()
            {
              new Category{CategoryId=1,CategoryName="Telefon"},
              new Category{CategoryId=2,CategoryName="Bilgisayar" }
            };

            ICollection<Category> categories1 = new List<Category>()
            {
              new Category{CategoryId=3,CategoryName="Gıda"},//obje
              new Category{CategoryId=4,CategoryName="Sağlık" },
              new Category{CategoryId=5,CategoryName="Kültür" }
            };

            //categories.AddRange(categories1); // addRange() arka tarata foreach kullanıyor.

            //foreach (Category item in categories)
            //{
            //    categories1.Add(item);
            //}

            foreach (Category item in categories1)
            {
                categories.Add(item);//item objenin bütün propertylerini kapsıyor..
            }

            foreach (Category item in categories)
            {
                Console.WriteLine(item.CategoryName);
            }
            Console.ReadKey();

        }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
