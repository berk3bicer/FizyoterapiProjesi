using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FizyoterapiAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string PatientName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string PatientEmail { get; set; } = string.Empty;

        [Required]
        [Phone]
        [RegularExpression(@"^[0-9\s]{10,13}$", ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string PatientPhone { get; set; } = string.Empty;

        [Required]
        public DateTime AppointmentDate { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        public int ServiceId { get; set; }

        [ValidateNever]
        public Service Service { get; set; } = null!;
    }
}