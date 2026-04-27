using FizyoterapiAPI.Models;

namespace FizyoterapiAPI.Services
{
    public interface ITherapistProfileService
    {
        Task<List<TherapistProfile>> GetAllAsync();
        Task<TherapistProfile?> GetByIdAsync(int id);
        Task<TherapistProfile> CreateAsync(TherapistProfile profile);
        Task<TherapistProfile?> UpdateAsync(int id, TherapistProfile profile);
        Task<bool> DeleteAsync(int id);
    }
}