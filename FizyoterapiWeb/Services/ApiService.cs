using System.Net.Http.Json;
using FizyoterapiWeb.Models;

namespace FizyoterapiWeb.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Service>> GetServicesAsync()
        {
            try
            {
                var services = await _httpClient.GetFromJsonAsync<List<Service>>("api/Services");
                return services ?? new List<Service>();
            }
            catch
            {
                return new List<Service>();
            }
        }

        public async Task<Service?> GetServiceByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Service>($"api/Services/{id}");
            }
            catch
            {
                return null;
            }
        }

        public async Task<TherapistProfile?> GetTherapistProfileAsync()
        {
            try
            {
                var profiles = await _httpClient.GetFromJsonAsync<List<TherapistProfile>>("api/TherapistProfiles");
                return profiles?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> CreateAppointmentAsync(Appointment appointment)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Appointments", appointment);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}