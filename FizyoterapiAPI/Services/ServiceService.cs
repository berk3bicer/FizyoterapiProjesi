using FizyoterapiAPI.Data;
using FizyoterapiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FizyoterapiAPI.Services
{
    public class ServiceService : IServiceService
    {
        private readonly ApplicationDbContext _context;

        public ServiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> GetAllAsync()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<Service?> GetByIdAsync(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task<Service> CreateAsync(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
            return service;
        }

        public async Task<Service?> UpdateAsync(int id, Service service)
        {
            var existing = await _context.Services.FindAsync(id);
            if (existing == null) return null;

            existing.Name = service.Name;
            existing.Description = service.Description;
            existing.ImageUrl = service.ImageUrl;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return false;

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}