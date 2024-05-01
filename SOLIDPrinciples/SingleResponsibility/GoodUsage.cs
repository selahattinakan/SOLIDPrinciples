﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibilityGoodUsage
{
 
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> ProductList)
        {
            ProductList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} - {x.Name}");
            });
        }
    }

    public class ProductRepository
    {
        private static List<Product> ProductList = new List<Product>();

        public List<Product> GetProducts => ProductList;

        public ProductRepository()
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

    }
}
