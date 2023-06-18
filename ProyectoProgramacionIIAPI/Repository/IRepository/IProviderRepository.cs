using ProyectoProgramacionIIAPI.Models;

namespace ProyectoProgramacionIIAPI.Repository.IRepository
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> Update(Provider entity);
    }
}
