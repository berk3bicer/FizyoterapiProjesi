using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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

        [ValidateNever]
        public Service Service { get; set; } = null!;
    }
}