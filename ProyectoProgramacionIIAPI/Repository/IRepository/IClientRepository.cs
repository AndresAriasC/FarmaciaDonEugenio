using ProyectoProgramacionIIAPI.Models;

namespace ProyectoProgramacionIIAPI.Repository.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> Update(Client entity);
    }
}
