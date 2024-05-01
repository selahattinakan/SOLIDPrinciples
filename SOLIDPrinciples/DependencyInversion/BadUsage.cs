using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversionBadUsage
{
    public class ProductService
    {
        private readonly ProductRepositorySQL _repository;

        public ProductService(ProductRepositorySQL productRepositorySQL)
        {
            _repository = productRepositorySQL;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositorySQL
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Sql Kalem", "Sql Silgi" };
        }
    }

    /*
     * High level low level'ı bilmemeli
     * yani product service direkt olarak ProductRepositorySQL sınıfını tanımamalı yoksa bu sınıfa bir bağımlılığı olur
     * bu durumdan kurtulmak için bir interface yaratacağız high level class bu interface'i tanıyacak
     */
}
