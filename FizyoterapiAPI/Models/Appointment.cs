using System.ComponentModel.DataAnnotations;

namespace FizyoterapiAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string PatientName { get; set; } = string.Empty;

        [Required]
        public string PatientEmail { get; set; } = string.Empty;

        [Required]
        public string PatientPhone { get; set; } = string.Empty;

        [Required]
        public DateTime AppointmentDate { get; set; }

        public string? Notes { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
    }
}