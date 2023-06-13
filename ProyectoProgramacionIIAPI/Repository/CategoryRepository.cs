using ProyectoProgramacionIIAPI.Data;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Repository.IRepository;
using System.Diagnostics;

namespace ProyectoProgramacionIIAPI.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly FarmaciaContext _db;
        public CategoryRepository(FarmaciaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Category> Update(Category entity)
        {
            _db.Categories.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
