using ProyectoProgramacionIIAPI.Data;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Repository.IRepository;

namespace ProyectoProgramacionIIAPI.Repository
{
    public class RepositoryClient : Repository<Client>, IClientRepository
    {
        private readonly FarmaciaContext _db;
        public RepositoryClient(FarmaciaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Client> Update(Client entity)
        {
            _db.Clients.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
