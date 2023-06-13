using ProyectoProgramacionIIAPI.Models;
using System.Diagnostics;

namespace ProyectoProgramacionIIAPI.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> Update(Category entity);
    }
}
