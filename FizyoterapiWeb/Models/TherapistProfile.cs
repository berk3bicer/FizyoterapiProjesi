namespace FizyoterapiWeb.Models
{
    public class TherapistProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string Specializations { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}