using TDD_WebApi_Example.Model;

namespace TDD_WebApi_Example.Interfaces
{
    public interface IProductService
    {
        Task<Product?> GetById(int id);
    }
}
