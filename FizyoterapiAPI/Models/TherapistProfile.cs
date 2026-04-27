using System.ComponentModel.DataAnnotations;

namespace FizyoterapiAPI.Models
{
    public class TherapistProfile
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Biography { get; set; } = string.Empty;

        [Required]
        public string Education { get; set; } = string.Empty;

        [Required]
        public string Specializations { get; set; } = string.Empty;

        public string? ProfileImageUrl { get; set; }

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;
    }

}