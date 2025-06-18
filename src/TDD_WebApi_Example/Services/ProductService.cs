using TDD_WebApi_Example.Interfaces;
using TDD_WebApi_Example.Model;

namespace TDD_WebApi_Example.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repository)
        {
            _repo = repository;
        }

        public async Task<Product?> GetById(int id)
        {
            if (id > 0)
            {
                return _repo.GetById(id);
            }

            return null;
        }
    }
}
