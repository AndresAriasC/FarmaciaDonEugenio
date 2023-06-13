using ProyectoProgramacionIIAPI.Models;

namespace ProyectoProgramacionIIAPI.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> Update(Product entity);
    }
}
