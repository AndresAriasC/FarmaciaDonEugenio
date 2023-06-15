using ProyectoProgramacionIIAPI.Data;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Repository.IRepository;

namespace ProyectoProgramacionIIAPI.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly FarmaciaContext _db;
        public UserRepository(FarmaciaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<User> Update(User entity)
        {
            _db.Users.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
