using FizyoterapiWeb.Models;

namespace FizyoterapiWeb.Services
{
    public interface IApiService
    {
        // Service işlemleri
        Task<List<Service>> GetServicesAsync();
        Task<Service?> GetServiceByIdAsync(int id);

        // TherapistProfile işlemleri
        Task<TherapistProfile?> GetTherapistProfileAsync();

        // Appointment işlemleri
        Task<bool> CreateAppointmentAsync(Appointment appointment);
    }
}