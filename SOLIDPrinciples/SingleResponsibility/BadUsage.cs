using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibilityBadUsage
{

    public class Product
    {
        //1. Özellik Alan belirtme
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts => ProductList;

        public Product()
        {
            ProductList = new()
            {
                new (){Id= 1, Name = "Kalem1"},
                new (){Id= 2, Name = "Kalem2"},
                new (){Id= 3, Name = "Kalem3"},
                new (){Id= 4, Name = "Kalem4"},
                new (){Id= 5, Name = "Kalem5"}
            };
        }

        //2. Özellik Crud operasyonları
        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductList.Any(p => p.Id == product.Id);

            if (!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index = ProductList.FindIndex(x => x.Id == product.Id);
                ProductList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductList.Find(p => p.Id == id);

            if (hasProduct == null) throw new Exception("Ürün bulunamadı");

            ProductList.Remove(hasProduct);
        }

        //3.Özellik Consola yazma
        public void WriteToConsole()
        {
            ProductList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} - {x.Name}");
            });
        }


        /*
         * Şu an bu class içinde 3 tane özellik mevcut
         * 1. özellik'te alan bilgilerini tutuyor, property yada field
         * 2. özelliği crud/repository(depolama) işlemleri yapılıyor
         * 3. özelliği de console'a yazma işlemleri yapılıyor
         * 
         * SingleResponsibility prensibine göre her class/method'ın bir tane sorumluluğu olmalı
         */
    }
}
