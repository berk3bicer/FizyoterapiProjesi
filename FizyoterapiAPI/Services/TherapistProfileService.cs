using FizyoterapiAPI.Data;
using FizyoterapiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FizyoterapiAPI.Services
{
    public class TherapistProfileService : ITherapistProfileService
    {
        private readonly ApplicationDbContext _context;

        public TherapistProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TherapistProfile>> GetAllAsync()
        {
            return await _context.TherapistProfiles.ToListAsync();
        }

        public async Task<TherapistProfile?> GetByIdAsync(int id)
        {
            return await _context.TherapistProfiles.FindAsync(id);
        }

        public async Task<TherapistProfile> CreateAsync(TherapistProfile profile)
        {
            _context.TherapistProfiles.Add(profile);
            await _context.SaveChangesAsync();
            return profile;
        }

        public async Task<TherapistProfile?> UpdateAsync(int id, TherapistProfile profile)
        {
            var existing = await _context.TherapistProfiles.FindAsync(id);
            if (existing == null) return null;

            existing.FullName = profile.FullName;
            existing.Title = profile.Title;
            existing.Biography = profile.Biography;
            existing.Education = profile.Education;
            existing.Specializations = profile.Specializations;
            existing.ProfileImageUrl = profile.ProfileImageUrl;
            existing.Email = profile.Email;
            existing.Phone = profile.Phone;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var profile = await _context.TherapistProfiles.FindAsync(id);
            if (profile == null) return false;

            _context.TherapistProfiles.Remove(profile);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}