using FizyoterapiWeb.Models;

namespace FizyoterapiWeb.Services
{
    public interface IApiService
    {
        Task<List<Service>> GetServicesAsync();
        Task<Service?> GetServiceByIdAsync(int id);
        Task<TherapistProfile?> GetTherapistProfileAsync();
        Task<bool> CreateAppointmentAsync(Appointment appointment);
    }
}
