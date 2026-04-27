using FizyoterapiAPI.Models;

namespace FizyoterapiAPI.Services
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllAsync();
        Task<Service?> GetByIdAsync(int id);
        Task<Service> CreateAsync(Service service);
        Task<Service?> UpdateAsync(int id, Service service);
        Task<bool> DeleteAsync(int id);
    }
}