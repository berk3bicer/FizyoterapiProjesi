namespace FizyoterapiWeb.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string PatientEmail { get; set; } = string.Empty;
        public string PatientPhone { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}