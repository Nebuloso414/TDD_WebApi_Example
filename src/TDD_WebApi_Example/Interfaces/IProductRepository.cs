using TDD_WebApi_Example.Model;

namespace TDD_WebApi_Example.Interfaces
{
    public interface IProductRepository
    {
        Product? GetById(int id);
    }
}
