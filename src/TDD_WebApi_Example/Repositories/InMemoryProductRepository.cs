using System.Data.SqlTypes;
using TDD_WebApi_Example.Interfaces;
using TDD_WebApi_Example.Model;

namespace TDD_WebApi_Example.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop" },
            new Product { Id = 2, Name = "Monitor" }
        };

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
