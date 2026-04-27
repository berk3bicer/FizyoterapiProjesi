using FizyoterapiAPI.Data;
using FizyoterapiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FizyoterapiAPI.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _context;

        public AppointmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            return await _context.Appointments
                .Include(a => a.Service)
                .ToListAsync();
        }

        public async Task<Appointment?> GetByIdAsync(int id)
        {
            return await _context.Appointments
                .Include(a => a.Service)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Appointment> CreateAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        public async Task<Appointment?> UpdateAsync(int id, Appointment appointment)
        {
            var existing = await _context.Appointments.FindAsync(id);
            if (existing == null) return null;

            existing.PatientName = appointment.PatientName;
            existing.PatientEmail = appointment.PatientEmail;
            existing.PatientPhone = appointment.PatientPhone;
            existing.AppointmentDate = appointment.AppointmentDate;
            existing.Notes = appointment.Notes;
            existing.ServiceId = appointment.ServiceId;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null) return false;

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}