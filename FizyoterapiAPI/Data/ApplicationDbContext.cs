using Microsoft.EntityFrameworkCore;
using FizyoterapiAPI.Models;

namespace FizyoterapiAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<TherapistProfile> TherapistProfiles { get; set; }



    }

}