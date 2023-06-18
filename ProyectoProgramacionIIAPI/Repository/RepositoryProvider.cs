using ProyectoProgramacionIIAPI.Data;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Repository.IRepository;

namespace ProyectoProgramacionIIAPI.Repository
{
    public class RepositoryProvider : Repository<Provider>, IProviderRepository
    {
        private readonly FarmaciaContext _db;
        public RepositoryProvider(FarmaciaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Provider> Update(Provider entity)
        {
            _db.Providers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
