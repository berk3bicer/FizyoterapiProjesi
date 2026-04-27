using FizyoterapiAPI.Models;

namespace FizyoterapiAPI.Services
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment?> GetByIdAsync(int id);
        Task<Appointment> CreateAsync(Appointment appointment);
        Task<Appointment?> UpdateAsync(int id, Appointment appointment);
        Task<bool> DeleteAsync(int id);
    }
}