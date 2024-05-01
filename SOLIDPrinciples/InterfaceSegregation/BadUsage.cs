using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregationBadUsage
{
    //class library 1 -> Read implementation -> ReadProductRepository
    //class library 2 -> Create/Update/Delete implementation

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);
    }


    //class library 1 sadece read işlemi yapacak, create,delete,update kullanılmadığı için ya boş bir metot olarak kalacak ya da exception fırlatacak
    public class ReadProductRepository : IProductRepository
    {
        public Product Create(Product p)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            return new Product();
        }

        public List<Product> GetList()
        {
            return new List<Product>();
        }

        public Product Update(Product p)
        {
            throw new NotImplementedException();
        }
    }


    /*
     * Bir interface'i miras alan sınıf o interface'in tüm özelliklerini kullanabilmeli, eğer kullanmıyorsa interface parçalanmalı 
     * ve o class'a uygun bir interface oluşturulmalı. bu örnekteki gibi iki farklı sınıfa aynı interface veriliyor ama ikisi farklı işlemleri kullanıyor
     * bu durumda GoodUsage.cs'de yapıldığı gibi bu iki sınıf için iki farklı interface yazılmalı
     */
}
