using ProyectoProgramacionIIAPI.Data;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Repository.IRepository;

namespace ProyectoProgramacionIIAPI.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly FarmaciaContext _db;

        public ProductRepository(FarmaciaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Product> Update(Product entity)
        {
            _db.Products.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
