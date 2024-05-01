using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregationGoodUsage
{
    //class library 1 -> Read implementation -> ReadProductRepository
    //class library 2 -> Create/Update/Delete implementation -> WriteProductRepository

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public interface IReadProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }

    public interface IWriteProductRepository
    {
        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);
    }


    //class library 1 -> Read implementation -> ReadProductRepository
    public class ReadProductRepository : IReadProductRepository
    {
        public Product GetById(int id)
        {
            return new Product();
        }

        public List<Product> GetList()
        {
            return new List<Product>();
        }
    }


    //class library 2 -> Create/Update/Delete implementation -> WriteProductRepository
    public class WriteProductRepository : IWriteProductRepository
    {
        public Product Create(Product p)
        {
            return p;
        }

        public Product Delete(Product p)
        {
            return p;
        }

        public Product Update(Product p)
        {
            return p;
        }
    }
}
