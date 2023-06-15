using ProyectoProgramacionIIAPI.Models;

namespace ProyectoProgramacionIIAPI.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Update(User entity);
    }
}
