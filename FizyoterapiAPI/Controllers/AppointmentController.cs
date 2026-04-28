using FizyoterapiAPI.Models;
using FizyoterapiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizyoterapiAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Appointment>>> GetAll()
        {
            var appointments = await _appointmentService.GetAllAsync();
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetById(int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);
            if (appointment == null) return NotFound();
            return Ok(appointment);
        }

        [HttpPost]
        public async Task<ActionResult<Appointment>> Create(Appointment appointment)
        {
            if (appointment.AppointmentDate < DateTime.Now)
            {
                return BadRequest(new { message = "Randevu tarihi geçmişte olamaz." });
            }

            var created = await _appointmentService.CreateAsync(appointment);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Appointment>> Update(int id, Appointment appointment)
        {
            var updated = await _appointmentService.UpdateAsync(id, appointment);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _appointmentService.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}