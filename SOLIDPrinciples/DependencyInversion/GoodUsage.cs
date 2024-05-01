using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversionGoodUsage
{
    public class ProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositorySQL : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Sql Kalem", "Sql Silgi" };
        }
    }

    public class ProductRepositoryOracle : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Oracle Kalem", "Oracle Silgi" };
        }
    }

    public interface IRepository
    {
        List<string> GetAll();
    }
}
